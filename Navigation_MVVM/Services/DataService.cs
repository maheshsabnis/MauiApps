using Navigation_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_MVVM.Services
{
    public class DataService
    {
        JobTasksInfo jobTasks;

        public DataService(JobTasksInfo jobTasks)
        {
            this.jobTasks = jobTasks;
        }

        public ObservableCollection<JobTask>GetJobTasks() 
        {
            return jobTasks;
        }

        public JobTask GetJobTasksById(int id)
        {
            var job = jobTasks.Where(j=>j.TaskId == id).FirstOrDefault();
            return job;
        }
    }
}
