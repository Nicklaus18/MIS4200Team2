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
        [Display(Name = "User")]
        public int userID { get; set; }
        [Display(Name = "Core Value")]
        public int ValueID { get; set; }

        public virtual CoreValues CoreValues { get; set; }
        public virtual Users Users { get; set; }

    }
}