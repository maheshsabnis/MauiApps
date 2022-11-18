using MAUI_RESTClient.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Text.Json;

namespace MAUI_RESTClient
{
    public partial class MainPage : ContentPage
    {
        //public ObservableCollection<WeatherForecast> WeatherForecastData { get; set; } = new ObservableCollection<WeatherForecast>();

        public ObservableCollection<JobTasks> Tasks { get; set; } = new ObservableCollection<JobTasks>();


        public static string ServiceBaseAddress =
         DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5000" : "http://localhost:5000";
        public static string ServiceUrl = $"{ServiceBaseAddress}/api/JobTask/";
        HttpClient client;
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
            OnPropertyChanged();
        }

        
        private  void ContentPage_Loaded(object sender, EventArgs e)
        {
           client= new HttpClient();    
        }

        private async void btnGetTasks_Clicked(object sender, EventArgs e)
        {
            try
            {
                Tasks.Clear();
                var result = await client.GetFromJsonAsync<ObservableCollection<JobTasks>>(ServiceUrl);
                if (result == null || result.Count == 0)
                    throw new Exception("Sorry! it seems no tasks");
                foreach (var record in result)
                {
                    Tasks.Add(record);
                }
                OnPropertyChanged();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Close");
            }
        }

        private async void btnAssignNewTasks_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AssignTask));
        }

        //private async void btnGetData_Clicked(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        WeatherForecastData.Clear();
        //       var result = await client.GetFromJsonAsync<ObservableCollection<WeatherForecast>>(ServiceUrl);
        //       // await DisplayAlert("Data", JsonSerializer.Serialize(WeatherForecastData), "Close");
        //        foreach (var record in result)
        //        {
        //            WeatherForecastData.Add(record);
        //        }

        //        // lstViewInfo.ItemsSource = WeatherForecastData;  
        //        OnPropertyChanged();
        //    }
        //    catch (Exception ex)
        //    {
        //        await DisplayAlert("Error", ex.Message, "Close");
        //    }
        //}
    }
}