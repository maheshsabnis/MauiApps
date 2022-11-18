namespace MAUI_APpActions
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureEssentials(e =>
                {
                    e.AddAppAction(new AppAction("actmessage", "My Messages", icon: "messages"));
                    e.AddAppAction(new AppAction("actappointments", "My Appointments", icon: "calende   r"));
                    e.AddAppAction(new AppAction("actinfo", "The App Info", icon: "appinfo"));
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            return builder.Build();
        }
    }
}