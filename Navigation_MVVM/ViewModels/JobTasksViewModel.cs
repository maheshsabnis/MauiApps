using CommunityToolkit.Mvvm.Input;
using Navigation_MVVM.Services;
using Navigation_MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_MVVM.ViewModels
{
   // [QueryProperty("Task","Task")]
    public partial class JobTasksViewModel : BaseViewModel
    {
        DataService service;
        public JobTasksViewModel(DataService service)
        {
            this.service = service;
            Tasks = this.service.GetJobTasks();
            
        }

        [RelayCommand]
        async void GoToTaskList()
        {
             await Shell.Current.GoToAsync(nameof(TaskList));
        }

        [RelayCommand]
        void GetJobTasks()
        { 
            Tasks = service.GetJobTasks();
        }

        [RelayCommand]
        async void GetJobDetails(int id)
        {
            
             await Shell.Current.GoToAsync($"{nameof(TaskDetails)}?Id={id}");
           // await Shell.Current.GoToAsync($"{nameof(TaskDetails)}");

            //await Shell.Current.GoToAsync($"{nameof(TaskDetails)}", new Dictionary<string, object> {
            //    { "Task", Task } 
            //});
        }
    }
}
