 
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_CheckList.Models
{
    public class Person
    {
        public string PersonName { get; set; }
        public int Age { get; set; }
    }

    public class Employee : INotifyPropertyChanged
    {
        string _EmpName;
        int _Age;

        public string EmpName
        {
            get { return _EmpName; }
            set {
                _EmpName = value;
               OnPropertyChanged(nameof(EmpName));
            }
        }

        public int Age
        {
            get { return _Age; }
            set { 
                _Age = value;
                OnPropertyChanged(nameof(Age));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string pName)
        {
            if(PropertyChanged !=null)
                PropertyChanged(this, new PropertyChangedEventArgs(pName));
        }
    }

    public class Persons : ObservableCollection<Person>
    {
        public Persons()
        {
            Add(new Person() { PersonName = "Akash", Age = 15});
            Add(new Person() { PersonName = "Ajay", Age = 25 });
            Add(new Person() { PersonName = "Kumar", Age = 11 });
            Add(new Person() { PersonName = "Krish", Age = 23 });
            Add(new Person() { PersonName = "Samir", Age = 17 });
            Add(new Person() { PersonName = "Sagar", Age = 24 });
            Add(new Person() { PersonName = "Vaibhav", Age = 55 }); 
            Add(new Person() { PersonName = "Amey", Age = 32 });
            Add(new Person() { PersonName = "Raj", Age = 45 });
            Add(new Person() { PersonName = "Sukumar", Age = 56 });
            Add(new Person() { PersonName = "Timir", Age = 42 });
        }
    }


    public class Employees : ObservableCollection<Employee>
    {
        public Employees()
        {
            Add(new Employee() { EmpName = "Akash", Age = 15 });
            Add(new Employee() { EmpName = "Ajay", Age = 25 });
            Add(new Employee() { EmpName = "Kumar", Age = 11 });
            Add(new Employee() { EmpName = "Krish", Age = 23 });
            Add(new Employee() { EmpName = "Samir", Age = 17 });
            Add(new Employee() { EmpName = "Sagar", Age = 24 });
            Add(new Employee() { EmpName = "Vaibhav", Age = 55 });
            Add(new Employee() { EmpName = "Amey", Age = 32 });
            Add(new Employee() { EmpName = "Raj", Age = 45 });
            Add(new Employee() { EmpName = "Sukumar", Age = 56 });
            Add(new Employee() { EmpName = "Timir", Age = 42 });
        }
    }
}
