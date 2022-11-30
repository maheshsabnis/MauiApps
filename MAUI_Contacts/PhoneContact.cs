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

        public string ContactId { get; set; }
        public string NamePrefix { get; set; }
        public string GiventName { get; set; }
        public string MiddleName { get; set; }
        public string FamilyName { get; set; }
        public string NameSuffix { get; set; }
        public string DisplayName { get; set; }

        void OnPropertyChanged(string pName)
        {
            if (PropertyChanged == null)
            {
                PropertyChanged(pName, null);
            }
        }
    }
}
