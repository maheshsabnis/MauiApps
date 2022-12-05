namespace MAUI_Preferences_Storage
{
    public partial class MainPage : ContentPage
    {
        private bool _CanSaveData = false;
        public bool CanSaveData { 
            get => _CanSaveData; 
            set 
            {
                _CanSaveData = value;
                OnPropertyChanged(nameof(CanSaveData));
            } 
        }

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext= this;  
        }

         

        private   void btnSavePreferences_Clicked(object sender, EventArgs e)
        {
            //_CanSaveData = !_CanSaveData;
            Preferences.Default.Set<bool>("CanSaveData", CanSaveData);
           OnPropertyChanged(nameof(CanSaveData));
        }

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            // Please set the default Value
            // so that if there is nothing saved in the preferences the default value is returned
           CanSaveData = Preferences.Default.Get<bool>("CanSaveData", false);
            OnPropertyChanged(nameof(CanSaveData));

        }
    }
}