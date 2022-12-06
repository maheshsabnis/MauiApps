using MAUI_SecureClient.Models;
using System.Net.Http.Json;

namespace MAUI_SecureClient.Views;

public partial class LoginUser : ContentPage
{
    public static string APIBaseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";

    AuthenticateUser authUser;
    HttpClient client;
    SecureResponse secureResponse;

    public LoginUser()
	{
		InitializeComponent();
        secureResponse= new SecureResponse();
        authUser= new AuthenticateUser();
        this.BindingContext= authUser;  
	}

    private async void btnLoginUser_Clicked(object sender, EventArgs e)
    {
		try
		{
            client = new HttpClient();

            var response = await client.PostAsJsonAsync<AuthenticateUser>($"{APIBaseAddress}/api/Auth/login", authUser);

            if (response.IsSuccessStatusCode)
            {
                await DisplayAlert("Message", "User is LoggedIn Successfully", "Close");

                secureResponse = await response.Content.ReadFromJsonAsync<SecureResponse>();

                await DisplayAlert("Token", secureResponse.Token, "Close");
            }


        }
		catch (Exception ex)
		{
            await DisplayAlert("Error", ex.Message, "Close");
		}
    }

    private void btnClear_Clicked(object sender, EventArgs e)
    {
        authUser = new AuthenticateUser();
    }
}