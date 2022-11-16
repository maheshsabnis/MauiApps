using Microsoft.Extensions.DependencyInjection;
using Navigation_MVVM.Models;
using Navigation_MVVM.Services;
using Navigation_MVVM.ViewModels;
using Navigation_MVVM.Views;

namespace Navigation_MVVM
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<JobTasksInfo>();
            builder.Services.AddSingleton<DataService>();
            builder.Services.AddSingleton<JobTasksViewModel>();
            builder.Services.AddSingleton<TaskDetailsViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<TaskList>();
            builder.Services.AddSingleton<TaskDetails>();
            return builder.Build();
        }
    }
}