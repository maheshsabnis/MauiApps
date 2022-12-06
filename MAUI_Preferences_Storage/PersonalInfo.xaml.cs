using MAUI_Preferences_Storage.Models;
using System.Text.Json;

namespace MAUI_Preferences_Storage;

public partial class PersonalInfo : ContentPage
{
    private PersonalInfoData personalInfoData;



    public PersonalInfo()
	{
		InitializeComponent();
        personalInfoData = new PersonalInfoData();
        this.BindingContext= this;
    }
 
    public PersonalInfoData PersonalInfoData
    { 
      get { return personalInfoData; }
        set
        {
            personalInfoData= value;    
            OnPropertyChanged(nameof(PersonalInfoData));
        }
    }

    private async void btnSaveDataToPreferences_Clicked(object sender, EventArgs e)
    {
		try
		{
            var personalData = JsonSerializer.Serialize<PersonalInfoData>(personalInfoData);
            Preferences.Default.Set<string>("PersonalInfo", personalData);
          OnPropertyChanged(nameof(PersonalInfoData));
		}
		catch (Exception ex)
		{
			await DisplayAlert("Error",ex.Message,"Close");
		}
    }

    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        try
        {
            var dataFromPreference = Preferences.Default.Get<string>("PersonalInfo", null);

            if(string.IsNullOrEmpty(dataFromPreference) || dataFromPreference == "null")
                personalInfoData =new PersonalInfoData();   
            else
                personalInfoData = JsonSerializer.Deserialize<PersonalInfoData>(dataFromPreference);

            OnPropertyChanged(nameof(PersonalInfoData));
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "Close");
        }
    }
}