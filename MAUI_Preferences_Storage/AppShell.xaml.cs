﻿namespace MAUI_Preferences_Storage
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PersonalInfo), typeof(PersonalInfo));
        }
    }
}