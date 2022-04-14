using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200Team2.Models
{
    public class BusinessUnit
    {
        public int BusinessUnitID { get; set; }
        public string unit { get; set; }

        ICollection<Users> Users { get; set; }

    }
}