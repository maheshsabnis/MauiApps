using System.ComponentModel;

namespace MAUI_Connetivity
{
    public partial class MainPage : ContentPage
    {
        string _NetworkStatus;
        

        public MainPage()
        {
            InitializeComponent();
            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
            this.BindingContext = this;
        }

        public string NetworkStatus
        {
            get
            {
                return _NetworkStatus;
            }
            set
            {
                _NetworkStatus = value;
                OnPropertyChanged(nameof(NetworkStatus));
            }
        }

        private void btnonnetivityTest_Clicked(object sender, EventArgs e)
        {
           
        }
        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (e.NetworkAccess == NetworkAccess.ConstrainedInternet)
                NetworkStatus = "Internet access is available but is limited.";
            else if (e.NetworkAccess != NetworkAccess.Internet)
                NetworkStatus = "Internet connetivity is lost.";

            foreach (var item in e.ConnectionProfiles)
            {
                switch (item)
                {
                    case ConnectionProfile.Bluetooth:
                        Console.Write("Bluetooth");
                        NetworkStatus = "Bluetooth";
                        break;
                    case ConnectionProfile.Cellular:
                        Console.Write("Cell");
                        NetworkStatus = "Cell";
                        break;
                    case ConnectionProfile.Ethernet:
                        Console.Write("Ethernet");
                        NetworkStatus = "Ethernet";
                        break;
                    case ConnectionProfile.WiFi:
                        Console.Write("WiFi");
                        NetworkStatus = "WiFi";
                        break;
                    default:
                        break;
                }
            }
        }

    }

    public class TestNetworkConnectivity  
    {
        private string _NetworkStatus;

        public string NetworkStatus 
        {
            get {
                return _NetworkStatus;
            }
            set {
                _NetworkStatus = value;
                
            }
        }

       

        // USe the onstructor to REgiter the COnnectivity Changed Event
        public TestNetworkConnectivity()=> Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        // USe the Destructor to relese the EVent

        ~TestNetworkConnectivity()=> Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;

       

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            if (e.NetworkAccess == NetworkAccess.ConstrainedInternet)
                NetworkStatus = "Internet access is available but is limited.";
            else if(e.NetworkAccess != NetworkAccess.Internet)
                NetworkStatus = "Internet connetivity is lost.";

            foreach (var item in e.ConnectionProfiles)
            {
                switch (item)
                {
                    case ConnectionProfile.Bluetooth:
                        Console.Write("Bluetooth");
                        NetworkStatus = "Bluetooth";
                        break;
                    case ConnectionProfile.Cellular:
                        Console.Write("Cell");
                        NetworkStatus = "Cell";
                        break;
                    case ConnectionProfile.Ethernet:
                        Console.Write("Ethernet");
                        NetworkStatus = "Ethernet";
                        break;
                    case ConnectionProfile.WiFi:
                        Console.Write("WiFi");
                        NetworkStatus = "WiFi";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}