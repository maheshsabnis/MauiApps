﻿using Foundation;
using UIKit;

namespace MAUI_APpActions
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public override void PerformActionForShortcutItem(UIApplication application, UIApplicationShortcutItem shortcutItem, UIOperationHandler completionHandler)
    => Platform.PerformActionForShortcutItem(application, shortcutItem, completionHandler);
    }
}