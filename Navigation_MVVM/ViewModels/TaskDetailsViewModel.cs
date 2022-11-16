using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Navigation_MVVM.Models;
using Navigation_MVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_MVVM.ViewModels
{
    [QueryProperty("Id","Id")]
    public partial class TaskDetailsViewModel : BaseViewModel
    {
        DataService service;
        [ObservableProperty]
        JobTask task;
        [ObservableProperty]
        int id;
        public TaskDetailsViewModel(DataService service)
        {
           // Task = new JobTask();
           this.service= service;
            Task = service.GetJobTasksById(Id);
        }
        [RelayCommand]
        async void GoBack()
        {
            Task = new JobTask();
            await Shell.Current.GoToAsync("..");
        }
    }
}
