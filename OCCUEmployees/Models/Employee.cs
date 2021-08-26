using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OCCUEmployees.Models
{

    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Depatment { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        
    }
}