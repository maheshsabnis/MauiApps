﻿namespace MAUI_Custom_Controls
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .ConfigureMauiHandlers((handlers) => 
                {
                    handlers.AddHandler(typeof(MyEntry),typeof(Xamarin))
                });
                

            // For Dependency Service and Injection

           
                

            return builder.Build();
        }
    }
}