using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OCCUEmployees.Models;

namespace OCCUEmployees.DAL
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var employees = new List<Employee>
            {
                //new Employee { FirstMidName = "Carson", LastName = "Alexander", Depatment = "Accoutning", Timestamp = DateTime.Parse("2005-09-01") },
                new Employee { FirstMidName = "Carson", LastName = "Alexander", Depatment = "Accoutning"},
                //new Employee { FirstMidName = "Meredith", LastName = "Alonso", Depatment = "IT", TimeStamp = DateTime.Parse("2002-09-01") },
                new Employee { FirstMidName = "Meredith", LastName = "Alonso", Depatment = "IT"},
                //new Employee { FirstMidName = "Arturo", LastName = "Anand", Depatment = "Services", TimeStamp = DateTime.Parse("2003-09-01") },
                new Employee { FirstMidName = "Arturo", LastName = "Anand", Depatment = "Services" },
                //new Employee { FirstMidName = "Gytis", LastName = "Barzdukas", Depatment = "Support", TimeStamp = DateTime.Parse("2002-09-01") },
                new Employee { FirstMidName = "Gytis", LastName = "Barzdukas", Depatment = "Support" },
            };
            employees.ForEach(s => context.Employee.Add(s));
            context.SaveChanges();





            var errors = new List<Errors>
            {
                new Errors { ID= 1, Error = "Error1"  },
                new Errors { ID= 2, Error = "Error2"  },
                new Errors { ID= 3, Error = "Error3"  },
                new Errors { ID= 4, Error = "Error4"  },
                new Errors { ID= 5, Error = "Error5"  },
                new Errors { ID = 6, Error = "Error6" },
                new Errors { ID = 7, Error = "Error7" },
                new Errors { ID = 8, Error = "Error8" },
                new Errors { ID = 9, Error = "Error9" },
                new Errors { ID = 10, Error = "Error10" },
                new Errors { ID = 11, Error = "Error11" },
                new Errors { ID = 12, Error = "Error12" },
                new Errors { ID = 13, Error = "Error13" },
                new Errors { ID = 14, Error = "Error14" },
                new Errors { ID = 15, Error = "Error15" },
                new Errors { ID = 16, Error = "Error16" },
                new Errors { ID = 17, Error = "Error17" },
                new Errors { ID = 18, Error = "Error18" },
                new Errors { ID = 19, Error = "Error19" },
                new Errors { ID = 20, Error = "Error20" },
                new Errors { ID = 21, Error = "Error21" },
                new Errors { ID = 22, Error = "Error22" },
                new Errors { ID = 23, Error = "Error23" },
                new Errors { ID = 24, Error = "Error24" },
            };
            errors.ForEach(s => context.Errors.Add(s));
            context.SaveChanges();
        }
            



    }
}