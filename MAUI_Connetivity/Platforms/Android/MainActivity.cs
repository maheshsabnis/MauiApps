﻿using Android.App;
using Android.Content.PM;
using Android.OS;
[assembly: UsesPermission(Android.Manifest.Permission.AccessNetworkState)]
namespace MAUI_Connetivity
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}