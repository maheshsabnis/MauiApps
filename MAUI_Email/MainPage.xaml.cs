using MAUI_Email.Models;

namespace MAUI_Email
{
    public partial class MainPage : ContentPage
    {
        EmailReceiver _EmailReceiver; 

        public MainPage()
        {
            InitializeComponent();
            _EmailReceiver = new EmailReceiver();
            this.BindingContext = this;
        }

        public EmailReceiver EmailReceiver
        {
            get 
            {
                return _EmailReceiver;
            }
            set
            {
                _EmailReceiver = value;
                OnPropertyChanged(nameof(EmailReceiver));
            }
        }
         

        private async void btrnSendEmail_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (Email.Default.IsComposeSupported)
                {

                 //EmailReceiver. = "Hello friends!";
                 //   string body = "It was great to see you last weekend.";
                 //   string[] recipients = new[] { "john@contoso.com", "jane@contoso.com" };

                    var message = new EmailMessage
                    {
                        Subject = EmailReceiver.Subject,
                        Body = EmailReceiver.Body,
                        BodyFormat = EmailBodyFormat.PlainText,
                        To = new List<string>(new[] { EmailReceiver.Receiver })
                    };
                    // Open the Default Email App
                    await Email.Default.ComposeAsync(message);
                    
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error",ex.Message, "Close");
            }
        }

        private async void btnSendMailWithAttachment_Clicked(object sender, EventArgs e)
        {
            try
            {

                if (Email.Default.IsComposeSupported)
                {
                    var result = await FilePicker.PickAsync(new PickOptions
                    {
                        PickerTitle = "Pick Image",
                        FileTypes = FilePickerFileType.Images,
                    });

                    if (result == null) return;
                  

                    var message = new EmailMessage
                    {
                        Subject = EmailReceiver.Subject,
                        Body = EmailReceiver.Body,
                        BodyFormat = EmailBodyFormat.PlainText,
                        To = new List<string>(new[] { EmailReceiver.Receiver })
                    };
                    var path = result.FullPath;
                    message.Attachments.Add(new EmailAttachment(result.FullPath));
                   

                    // Open the Default Email App
                    await Email.Default.ComposeAsync(message);
                }

              
                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Close");
            }
        }
    }
}