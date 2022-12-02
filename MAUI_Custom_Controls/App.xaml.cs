using Microsoft.Maui.Platform;

namespace MAUI_Custom_Controls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            // We have defined an Entry subclass and use it in a XAML page. 
            //The aimis so that we can change the appearance of the Entry control. 
            //In App.cs, add the following:

            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(IView.Background), (handler, view) =>
            {
                if (view is MyEntry)
                {
#if ANDROID
                handler.PlatformView.SetBackgroundColor(Colors.Yellow.ToPlatform());
#elif IOS
                    handler.PlatformView.BackgroundColor = Colors.LightGray.ToPlatform();
                    handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.Line;
#elif WINDOWS
                    handler.PlatformView.Background = Colors.LightGray.ToPlatform();
#endif
                }
            });

            // for the Button
            Microsoft.Maui.Handlers.ButtonHandler.Mapper.AppendToMapping(nameof(IView.Background), (handler, view) => 
            {
#if ANDROID
                 handler.PlatformView.SetBackgroundColor(Colors.DarkRed.ToPlatform());
#elif IOS
                 handler.PlatformView.SetBackgroundColor(Colors.DarkSeaGreen.ToPlatform());
#elif WINDOWS
                handler.PlatformView.Background = Colors.Magenta.ToPlatform();
#endif
            });

        }
    }
}