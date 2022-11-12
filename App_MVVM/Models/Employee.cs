using System;
using System.ComponentModel;

namespace App_MVVM.Models
{
    public class Employee
    {
        public int? EmpNo { get; set; } = 0;
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public string Designation { get; set; }
        public decimal? Salary { get; set; } = 0;
 
    }
}

