using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StylesParser
{
    public class Parser
    {
        public string[] ViewsFiles;
        public string[] CssFiles;
        private readonly RulesDataContext db = new RulesDataContext();

        public Parser()
        {
            
        }
        public Parser(string[] views, string[] cssFiles)
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

        private List<selectorsRank> GetSelectors()
        {
            List<selectorsRank> selsList = new List<selectorsRank>();
            foreach (var cssFile in CssFiles)
            {
                selsList.AddRange(db.selectorsRanks.Where(x => x.FileName == cssFile));
            }
            return selsList;
        }

        public List<string> GetIntersection()
        {
            var classesList = GetViewsClasses();
            var classesSelectorsList = GetSelectors().Where(x => x.ParentSelectorId==null && x.Rank == 0 && x.Name.StartsWith("."));

            return
                classesList.Select(x => x.SelectorName)
                    .Intersect(classesSelectorsList.Select(x => x.Name.Replace(".", "")))
                    .ToList();
        }
    }
}
