using Navigation_MVVM.ViewModels;

namespace Navigation_MVVM
{
    public partial class MainPage : ContentPage
    {
     

        public MainPage(JobTasksViewModel viewModel)
        {
            InitializeComponent();
           
            this.BindingContext= viewModel;
        }
    }
}