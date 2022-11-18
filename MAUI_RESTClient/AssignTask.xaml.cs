using MAUI_RESTClient.Models;
using System.Net.Http.Json;

namespace MAUI_RESTClient;

public partial class AssignTask : ContentPage
{

    public static string ServiceBaseAddress =
        DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
    public static string ServiceUrl = $"{ServiceBaseAddress}/api/JobTask/";
    HttpClient client;

	public JobTasks	Task { get; set; }

	public AssignTask()
	{
		InitializeComponent();
		Task = new JobTasks();
		this.BindingContext= this;	

		OnPropertyChanged(nameof(Task));
	}

    private async void btnAssignTask_Clicked(object sender, EventArgs e)
    {
		try
		{
			client = new HttpClient();
            OnPropertyChanged(nameof(Task));
			var res = await client.PostAsJsonAsync<JobTasks>(ServiceUrl, Task);
			if (res.IsSuccessStatusCode)
			{
				await Shell.Current.GoToAsync("..");
			}
			else
			{
				await DisplayAlert("Error","The Task is not assigned.", "Close");
			}
		}
		catch (Exception ex)
		{
			throw ex;
		}
    }
}