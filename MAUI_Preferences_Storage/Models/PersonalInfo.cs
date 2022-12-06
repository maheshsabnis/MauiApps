using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Preferences_Storage.Models
{
    public class PersonalInfoData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string firstName;
        string middleName;   
        string lastName;
        string mobileNo;
        string emailAddress;

        public string FirstName { get => firstName; set { firstName = value; RaisePropertyChanged(); } }
        public string MiddleName { get => middleName; set { middleName = value; RaisePropertyChanged(); } }
        public string LastName { get => lastName; set { lastName = value; RaisePropertyChanged(); } }
        public string MobileNo { get => mobileNo; set { mobileNo = value; RaisePropertyChanged(); } }
        public string EmailAddress { get => emailAddress; set { emailAddress = value; RaisePropertyChanged(); } }

        private void RaisePropertyChanged([CallerMemberName] string pName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(pName));
        }
    }
}
