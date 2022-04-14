using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200Team2.Models
{
    public class userTitle
    {
        public int usertitleID { get; set; }

        public string titleUser { get; set; }

        ICollection<Users> Users { get; set; }
    }
}