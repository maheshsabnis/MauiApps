
using MAUI_SMSApp.Models;
using Microsoft.Maui.ApplicationModel.Communication;
using Communication = Microsoft.Maui.ApplicationModel.Communication;
namespace MAUI_SMSApp
{
    public partial class MainPage : ContentPage
    {
        private SMSModel _SmsModel;

        public MainPage()
        {
            InitializeComponent();
            _SmsModel = new SMSModel();
        }
        public SMSModel SMSModel
        {
            get { return _SmsModel; }
            set
            {
                _SmsModel = value;
                OnPropertyChanged(nameof(SMSModel));
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

        private async void btnSendMessage_Clicked(object sender, EventArgs e)
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
                    //string id = contact.Id;
                    //string namePrefix = contact.NamePrefix;
                    //string givenName = contact.GivenName;
                    //string middleName = contact.MiddleName;
                    //string familyName = contact.FamilyName;
                    //string nameSuffix = contact.NameSuffix;
                    //string displayName = contact.DisplayName;
                    List<ContactPhone> phones = contact.Phones; // List of phone numbers
                                                                //List<ContactEmail> emails = contact.Emails; // List of email addresses


                    if (Sms.Default.IsComposeSupported)
                    {
                        //string[] recipients = new[] { };
                        //string text = "Hello, I'm interested in buying your vase.";
                        SMSModel.RecipantContact = phones[0].PhoneNumber;

                        var message = new SmsMessage(SMSModel.Text, SMSModel.RecipantContact);

                        await Sms.Default.ComposeAsync(message);
                    }

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

         

         
    }
}