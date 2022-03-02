using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200Team2.Models
{
    public class Recognition
    {
        public int recognitionID { get; set; }
        public int userID { get; set; }
        public int ValueID { get; set; }

        public virtual CoreValues CoreValues { get; set; }
        public virtual Users Users { get; set; }

    }
}