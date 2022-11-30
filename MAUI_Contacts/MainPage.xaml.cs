using Microsoft.Maui.ApplicationModel.Communication;
using Communication = Microsoft.Maui.ApplicationModel.Communication;
namespace MAUI_Contacts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnGetSingleContact_Clicked(object sender, EventArgs e)
        {
            try
            {
                PermissionStatus status = await CheckAndRequestContactsReadPermission();
                if (status == PermissionStatus.Granted)
                {
                    //var contact = await Microsoft.Maui.ApplicationModel.Communication.Contacts.Default.PickContactAsync();

                    var contact = await Contacts.Default.PickContactAsync();

                    if (contact == null)
                        throw new Exception("No Contact is selected");

                    // Get the Contact details
                    string id = contact.Id;
                    string namePrefix = contact.NamePrefix;
                    string givenName = contact.GivenName;
                    string middleName = contact.MiddleName;
                    string familyName = contact.FamilyName;
                    string nameSuffix = contact.NameSuffix;
                    string displayName = contact.DisplayName;
                    List<ContactPhone> phones = contact.Phones; // List of phone numbers
                    List<ContactEmail> emails = contact.Emails; // List of email addresses
                }
                else
                {
                    throw new Exception("Please grant Permissions to Read Contacts");
                }

                

            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Close");
            }
        }


        /// <summary>
        /// The Method to Check The Permissions
        /// </summary>
        /// <returns></returns>        
        public async Task<PermissionStatus> CheckAndRequestContactsReadPermission()
        {
            PermissionStatus status = await Permissions.CheckStatusAsync<Permissions.ContactsRead>();

            if (status == PermissionStatus.Granted)
                return status;

            if (status == PermissionStatus.Denied && DeviceInfo.Platform == DevicePlatform.iOS)
            {
                // Prompt the user to turn on in settings
                // On iOS once a permission has been denied it may not be requested
                // again from the application
                await DisplayAlert("Warning", "Turn On Settings to Read Contacts", "Close");
                return status;
            }

            if (Permissions.ShouldShowRationale<Permissions.ContactsRead>())
            {
                // Prompt the user with additional information as to why the permission is needed
                await DisplayAlert("Warning", "Make Sure that Contaact Read Permissions are needed", "Close");
            }

            status = await Permissions.RequestAsync<Permissions.ContactsRead>();

            return status;
        }
    }
}