using MAUI_Custom_List.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Custom_List.ViewModel
{
    public class ContactsViewModel
    {
        public ObservableCollection<ContactInfo> Contacts { get; set; }

        public ContactsViewModel()
        {
           
            Contacts = new ObservableCollection<ContactInfo>();

            foreach (var record in GenerateContactDetails())
            {
                Contacts.Add(record);
            }
        }

        private List<ContactInfo> GenerateContactDetails()
        {
            List<ContactInfo> lstContacts = new List<ContactInfo>();
            lstContacts.Add(new ContactInfo() { ContactName = "Mahesh", ContactNumber = 999999,CallTime = "11:20" });
            lstContacts.Add(new ContactInfo() { ContactName = "Vikram", ContactNumber = 898888, CallTime = "10:20" });
            lstContacts.Add(new ContactInfo() { ContactName = "Manish", ContactNumber = 777777, CallTime = "12:20" });
            lstContacts.Add(new ContactInfo() { ContactName = "Tejas", ContactNumber = 666666, CallTime = "09:20" });
            lstContacts.Add(new ContactInfo() { ContactName = "Amey", ContactNumber = 555555, CallTime = "08:20" });
            lstContacts.Add(new ContactInfo() { ContactName = "Baban", ContactNumber = 123456, CallTime = "07:20" });
            lstContacts.Add(new ContactInfo() { ContactName = "Chaitanya", ContactNumber = 654321, CallTime = "06:20" });
            lstContacts.Add(new ContactInfo() { ContactName = "Deepak", ContactNumber = 999999, CallTime = "11:20" });
            return lstContacts; 
        }
    }
}
