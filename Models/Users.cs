using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200Team2.Models
{
    public class Users
    {
        public int UsersID { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        public string fullName
        { 
            get
            {
                return firstName + ", " + lastName;
            }
        }

        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Phone")]
        public string phone { get; set; }
        [Display(Name = "Date Registered")]
        public DateTime registeredDate { get; set; }
        ICollection<Recognition> recognitions { get; set; }

    }
}