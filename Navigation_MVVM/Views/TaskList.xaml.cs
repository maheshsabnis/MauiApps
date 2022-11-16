using Navigation_MVVM.ViewModels;

namespace Navigation_MVVM.Views;

public partial class TaskList : ContentPage
{
	public TaskList(JobTasksViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext= viewModel;
	}
}