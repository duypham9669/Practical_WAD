using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical_WAD.Models
{
    public class Employees
    {
        [System.ComponentModel.DataAnnotations.Key]
        public String EmployeeId { get; set; }
        public String EmployeeName { get; set; }
        public String Department { get; set; }
        public int Salary { get; set; }

    }
}