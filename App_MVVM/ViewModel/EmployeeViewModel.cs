using System;
using System.Collections.ObjectModel;
using App_MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace App_MVVM.ViewModel
{
	public partial class EmployeeViewModel : ObservableObject
	{
		[ObservableProperty]
		private Employee employee;

		[ObservableProperty]
		private ObservableCollection<Employee> employees;

		EmployeeDataAccess dataAccess;

		public EmployeeViewModel(EmployeeDataAccess dataAccess)
		{
			this.dataAccess = dataAccess;
			Employee = new Employee();
			Employees = new ObservableCollection<Employee>();
		}

		[RelayCommand]
		void GetEmployees()
		{
			Employees = dataAccess.Get();
		}
        [RelayCommand]
        void AddEmployee()
        {
            Employees = dataAccess.Create(Employee);
            Employee = new Employee();
        }
    }
}

