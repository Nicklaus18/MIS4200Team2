using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team2.Models
{
    public class CoreValues
    {
        public int CoreValuesID { get; set; }
        
        [Display(Name = "Core Value 1")]
        public string CoreValue1 { get; set; }
        [Display(Name = "Description")]
        public string DescriptionValue1 { get; set; }
        [Display(Name = "Core Value 2")]
        public string CoreValue2 { get; set; }
        [Display(Name = "Description")]
        public string DescriptionValue2 { get; set; }
        [Display(Name = "Core Value 3")]
        public string CoreValue3 { get; set; }
        [Display(Name = "Description")]
        public string DescriptionValue3 { get; set; }
        [Display(Name = "Core Value 4")]
        public string CoreValue4 { get; set; }
        [Display(Name = "Description")]
        public string DescriptionValue4 { get; set; }
        [Display(Name = "Core Value 5")]
        public string CoreValue5 { get; set; }
        [Display(Name = "Description")]
        public string DescriptionValue5 { get; set; }
        [Display(Name = "Core Value 6")]
        public string CoreValue6 { get; set; }
        [Display(Name = "Description")]
        public string DescriptionValue6 { get; set; }
        [Display(Name = "Core Value 7")]
        public string CoreValue7 { get; set; }
        [Display(Name = "Description")]
        public string DescriptionValue7 { get; set; }
        ICollection<Recognition> recognitions { get; set; }
    }
}