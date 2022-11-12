
using App_MVVM.Models;
using App_MVVM.ViewModel;

namespace App_MVVM;


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
		builder.Services.AddSingleton<EmployeeDataAccess>();
		builder.Services.AddSingleton<EmployeeViewModel>();
        builder.Services.AddSingleton<MainPage>();

        return builder.Build();
	}
}

