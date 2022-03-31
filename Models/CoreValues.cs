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
        
        [Display(Name = "Core Value")]
        public string CoreValue { get; set; }
        [Display(Name = "Description")]
        public string DescriptionValue { get; set; }

            ICollection<Recognition> recognitions { get; set; }
    }
}