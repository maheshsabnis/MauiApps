 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_MultiBinding.Models
{
    public class Person
    {
        public string PersonName { get; set; }
        public int Age { get; set; }
    }

    public class Persons : List<Person>
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
}
