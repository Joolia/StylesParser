using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using StylesParser.Models;

namespace StylesParser
{
    public class SelectorsComparer
    {
        public string[] ViewsFiles;
        public string[] CssFiles;
        private readonly RulesDataContext db = new RulesDataContext();



        public SelectorsComparer(string[] views, string[] cssFiles)
        {
            ViewsFiles = views;
            CssFiles = cssFiles;
        }

        private List<view> GetViewsIdsNames()
        {
            List<view> viewsList = new List<view>();
            foreach (var path in ViewsFiles)
            {
                viewsList.Add(db.views.SingleOrDefault(x => x.Path == path));
            }

            return viewsList;
        }

        private List<View_Selector> GetViewsClasses()
        {
            List<View_Selector> classesList = new List<View_Selector>();
            foreach (var sel in GetViewsIdsNames())
            {
                classesList.AddRange(db.View_Selectors.Where(x => x.ViewId == sel.Id));
            }
            return classesList;
        }

        private List<View_Selector> GetSingleViewClasses(string viewPath)
        {
            view viewObj = db.views.FirstOrDefault(x => x.Path == viewPath);
            List<View_Selector> classesList = new List<View_Selector>();
            classesList.AddRange(db.View_Selectors.Where(x => x.ViewId == viewObj.Id));
            return classesList;
        }

        private List<selectorsRank> GetSelectors()
        {
            List<selectorsRank> selsList = new List<selectorsRank>();
            foreach (var cssFile in CssFiles)
            {
                selsList.AddRange(db.selectorsRanks.Where(x => x.FileName == Path.GetFileName(cssFile)));
            }
            return selsList;
        }

        public List<Tuple<string, string>> GetIntersection()
        {
            var classesList = GetViewsClasses().Select(x => new BaseSelectorClass { SourceId = x.ViewId, SourceType = (int)SourceType.CSHTML, SelectorName = x.SelectorName});
            var classesSelectorsList =
                GetSelectors().Where(x => x.ParentSelectorId == null && x.Rank == 0 && x.Name.StartsWith("."))
                .Select(x => new BaseSelectorClass { SourceCSS = x.FileName, SourceType = (int)SourceType.CSS, SelectorName = x.Name.Replace(".", String.Empty) });

            MyComparer comp = new MyComparer();

            var selectorsNamesUsedInView =
                classesList.Intersect(classesSelectorsList, comp)
                    .ToList();

            List<Tuple<string, string>> usageSelectorsList = new List<Tuple<string, string>>();

            foreach (var sr in classesList)
            {
                usageSelectorsList.Add(selectorsNamesUsedInView.Contains(sr)
                    ? new Tuple<string, string>(sr.SelectorName, "used")
                    : new Tuple<string, string>(sr.SelectorName, "NOT used"));
            }


            //foreach (var viewsFile in ViewsFiles)
            //{
            //    foreach (var viewClass in GetSingleViewClasses(viewsFile))
            //    {
            //        SelectorsUsage su = new SelectorsUsage();
            //        if (
            //            GetSelectors()
            //                .Where(x => x.ParentSelectorId == null && x.Rank == 0 && x.Name.StartsWith("."))
            //                .Select(x => x.Name.Replace(".", ""))
            //                .Contains(viewClass.SelectorName))
            //        {
            //            su.SelectorId = GetSelectors()
            //                .FirstOrDefault(
            //                    x => x.ParentSelectorId == null && x.Rank == 0 && x.Name == viewClass.SelectorName)
            //                .Id;
            //            su.ViewId = db.views.FirstOrDefault(x => x.Path == viewsFile).Id;
            //            su.SelectorUsage = true;
            //        }
            //    }
            //}

            return usageSelectorsList;
        }

        public void SaveIntersectionResultToDB(List<selectorsRank> selsList)
        {
            foreach (var selector in selsList)
            {
            }
        }
    }

    public class MyComparer : IEqualityComparer<BaseSelectorClass>
    {
        public bool Equals(BaseSelectorClass x, BaseSelectorClass y)
        {
            return String.Compare(x.SelectorName, y.SelectorName) == 0;
        }

        public int GetHashCode(BaseSelectorClass obj)
        {
            return obj.SelectorName.GetHashCode();
        }
    }
}
