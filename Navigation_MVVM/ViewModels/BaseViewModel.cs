using CommunityToolkit.Mvvm.ComponentModel;
using Navigation_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_MVVM.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
      
        [ObservableProperty]
        ObservableCollection<JobTask> tasks;
       
             
    }
}
