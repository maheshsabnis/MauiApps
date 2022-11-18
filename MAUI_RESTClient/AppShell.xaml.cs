namespace MAUI_RESTClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AssignTask), typeof(AssignTask));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        }
    }
}