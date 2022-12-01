using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Contacts
{
    public class PhoneContact : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int Id { get; set; } = 0;
        public string ContactId { get; set; } = "DDD";
        public string NamePrefix { get; set; } =string.Empty;
        public string GivenName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string FamilyName { get; set; } = string.Empty;

        public string NameSuffix { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public List<ContactPhone>? Phones { get; set; } 
        public List<ContactEmail>? Emails { get; set; }

        void OnPropertyChanged(string pName)
        {
            if (PropertyChanged == null)
            {
                PropertyChanged(pName, null);
            }
        }
    }
}
