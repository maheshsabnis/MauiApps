using MAUI_SecureClient.Models;
using System.Net.Http.Json;

namespace MAUI_SecureClient.Views;

public partial class RegisterUser : ContentPage
{
    public static string APIBaseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";

    RegisterNewUser registerNewUser;

    HttpClient client;
	public RegisterUser()
	{
		InitializeComponent();
        registerNewUser = new RegisterNewUser ();
        this.BindingContext= registerNewUser;
	}

    private async void btnRegisterNewUser_Clicked(object sender, EventArgs e)
    {
		try
		{
            client= new HttpClient ();

            var response = await client.PostAsJsonAsync<RegisterNewUser>($"{APIBaseAddress}/api/Auth/register",registerNewUser);

            if (response.IsSuccessStatusCode)
            {
                await DisplayAlert("Message", "User is Created Successfully", "Close");
            }
		}
		catch (Exception ex)
		{
            await DisplayAlert("Error", ex.Message, "Close");
		}
    }

    private void btnClear_Clicked(object sender, EventArgs e)
    {
        registerNewUser = new RegisterNewUser();
    }
}