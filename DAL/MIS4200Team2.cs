using MIS4200Team2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MIS4200Team2.DAL
{
    public class MIS4200Team2Context : DbContext
    {
        public MIS4200Team2Context() : base("name=DefaultConnection")
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<CoreValues> CoreValues { get; set; }
        public DbSet<Recognition> Recognitions { get; set; }



    }
}