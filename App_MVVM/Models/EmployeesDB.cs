using System;
using System.Collections.ObjectModel;

namespace App_MVVM.Models
{
	public class EmployeesDB : ObservableCollection<Employee>
	{
		public EmployeesDB()
		{
			Add(new Employee() {EmpNo=101,EmpName="Mahesh",DeptName="Information Technology",Designation="Director", Salary=300000 });
            Add(new Employee() { EmpNo = 102, EmpName = "Tejas", DeptName = "Hardware", Designation = "Director", Salary = 200000 });
        }
	}
}

