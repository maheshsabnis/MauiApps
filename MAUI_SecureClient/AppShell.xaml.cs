using MAUI_SecureClient.Views;

namespace MAUI_SecureClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(RegisterUser), typeof(RegisterUser));
            Routing.RegisterRoute(nameof(LoginUser), typeof(LoginUser));
        }
    }
}