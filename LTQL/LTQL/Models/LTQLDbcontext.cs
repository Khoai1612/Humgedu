using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    public class LTQLDbcontext : DbContext
    {
        public LTQLDbcontext() : base("LTQLDbcontext")
        {
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<People> Peoples { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet <Account> Accounts { get; set; }
    }
}
//DESKTOP - JLO7L7B