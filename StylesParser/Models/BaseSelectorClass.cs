using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StylesParser.Models
{
    public class BaseSelectorClass 
    {
        public int SourceId { get; set; }
        public string SourceCSS { get; set; }

        public int SourceType { get; set; }
        public string SelectorName { get; set; }
    }


    public enum SourceType
    {
        CSHTML = 1,
        CSS = 2
    }

}
