using Navigation_MVVM.Views;

namespace Navigation_MVVM
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TaskList), typeof(TaskList));
            Routing.RegisterRoute(nameof(TaskDetails), typeof(TaskDetails));
        }
    }
}