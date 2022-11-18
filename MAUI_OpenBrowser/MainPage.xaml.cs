using System.Reflection.Metadata.Ecma335;

namespace MAUI_OpenBrowser
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnOpenBrowser_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Uri uri = new Uri("https://www.microsoft.com");
                Uri uri = new Uri(((WebSites)lstUrls.SelectedItem).URL);
                BrowserLaunchOptions options = new BrowserLaunchOptions()
                {
                    LaunchMode = BrowserLaunchMode.SystemPreferred,
                    TitleMode = BrowserTitleMode.Show,
                    PreferredToolbarColor = Colors.Violet,
                    PreferredControlColor = Colors.SandyBrown
                };

                await Browser.Default.OpenAsync(uri, options);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Close");
            }
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            lstUrls.ItemsSource= new List<WebSites>() 
            { 
              new WebSites("Web Net Helper", "https://www.webnethelper.com"),
              new WebSites("DNC", "https://www.dotnetcurry.com"),
              new WebSites("DevC", "https://www.devcurry.com")
            };
        }
    }

    internal class WebSites
    {
        public WebSites(string siteName, string uRL)
        {
            SiteName = siteName;
            URL = uRL;
        }

        public string SiteName { get; set; }
        public string URL { get; set; }
    }
}