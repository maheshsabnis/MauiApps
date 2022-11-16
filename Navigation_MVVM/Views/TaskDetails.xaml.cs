using Navigation_MVVM.ViewModels;
using System.Text.Json;

namespace Navigation_MVVM.Views;

public partial class TaskDetails : ContentPage
{
	public TaskDetails(TaskDetailsViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel.Task;

		//DisplayAlert("Message", JsonSerializer.Serialize(viewModel.Task),"");
	}
}