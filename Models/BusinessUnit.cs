using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team2.Models
{
    public class BusinessUnit
    {
        public int BusinessUnitID { get; set; }

        [Display(Name = "Business Unit")]
        public string unit { get; set; }

        ICollection<Users> Users { get; set; }

    }
}