using System;
using System.Collections.ObjectModel;
using App_MVVM.Models;


namespace App_MVVM.Models
{
	public class EmployeeDataAccess
	{
		EmployeesDB employees;
		public EmployeeDataAccess()
		{
			employees = new EmployeesDB();
		}

		public ObservableCollection<Employee> Create(Employee emp)
		{
			employees.Add(emp);
			return employees;
		}

        public ObservableCollection<Employee> Get()
        {
            return employees;
        }

    }
}

