using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDetails.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
    }
}