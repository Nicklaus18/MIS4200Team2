using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200Team2.Models
{
    public class Users
    {
        public int userID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName
        { 
            get
            {
                return firstName + ", " + lastName;
            }
        }

        public string email { get; set; }
        public string phone { get; set; }
        public DateTime registeredDate { get; set; }

    }
}