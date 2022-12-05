namespace MAUI_Secure_Storage
{
    public partial class MainPage : ContentPage
    {
         

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnSaveSecretKey_Clicked(object sender, EventArgs e)
        {
            try
            {
                await SecureStorage.Default.SetAsync("SecretKey", saveSecretKey.Text);
                saveSecretKey.Text= string.Empty;   
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Close");
            }
        }

        private async void btnAccessSecretKey_Clicked(object sender, EventArgs e)
        {
            try
            {
               var secretKey=  await SecureStorage.Default.GetAsync("SecretKey");
                accessSecretKey.Text = secretKey;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Close");
            }
        }
    }
}