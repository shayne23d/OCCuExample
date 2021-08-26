using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OCCUEmployees.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace OCCUEmployees.DAL
{
    public class EmployeeContext : DbContext
    {

        public EmployeeContext() : base("EmployeeContext")
        {
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Errors> Errors { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}