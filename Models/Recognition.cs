using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team2.Models
{
    public class Recognition
    {
        public int RecognitionID { get; set; }
        [Display(Name = "User Name")]
        public Guid UsersID { get; set; }
        [Display(Name = "Core Value")]
        public int CoreValuesID { get; set; }
        [Display(Name = "Reason")]
        public string descriptionOfValue { get; set; }
        public virtual Users Users { get; set; }
        public virtual CoreValues CoreValues { get; set; }
        
    }
}