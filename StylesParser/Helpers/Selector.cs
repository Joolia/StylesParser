using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StylesParser
{
    public class Selector
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RuleId { get; set; }
        public int? ParentSelectorId { get; set; }
        public int Rank { get; set; }
        public string CSSFileName { get; set; }
        public int? ViewFileId { get; set; }
    }
}
