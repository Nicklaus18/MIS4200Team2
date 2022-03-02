using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200Team2.Models
{
    public class CoreValues
    {
        public int ValueID { get; set; }
        public string CoreValue1 { get; set; }
        public string DescriptionValue1 { get; set; }
        public string CoreValue2 { get; set; }
        public string DescriptionValue2 { get; set; }
        public string CoreValue3 { get; set; }
        public string DescriptionValue3 { get; set; }
        public string CoreValue4 { get; set; }
        public string DescriptionValue4 { get; set; }
        public string CoreValue5 { get; set; }
        public string DescriptionValue5 { get; set; }
        public string CoreValue6 { get; set; }
        public string DescriptionValue6 { get; set; }
        public string CoreValue7 { get; set; }
        public string DescriptionValue7 { get; set; }
        ICollection<Recognition> recognitions { get; set; }
    }
}