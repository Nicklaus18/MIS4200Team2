using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team2.Models
{
    public class Users
    {
        public Guid UsersID { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Display(Name = "User")]
        public string fullName
        { 
            get
            {
                return firstName + ", " + lastName;
            }
        }
       
        [Display(Name = "Business Unit")]
        public int BusinessUnitID { get; set; }

        [Display(Name = "Title")]
        public int usertitleID { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Phone")]
        public string phone { get; set; }
        [Display(Name = "Date Hire")]
        public DateTime registeredDate { get; set; }
        [Display(Name = "Amount of Recognitions")]
        ICollection<Recognition> recognitions { get; set; }

        public virtual BusinessUnit businessUnit { get; set; }

        public virtual userTitle usertitles { get; set; }

    }
}