using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_MVVM.Models
{
    public class JobTasksInfo : ObservableCollection<JobTask>
    {
        public JobTasksInfo()
        {
            Add(new JobTask() {TaskId=101,TaskName="Requirements Gathering",Details="Get Application Implementation Requirements.", AssignTo="Rohit", TaskAssignDate= new DateTime(2022,2,10) });
            Add(new JobTask() { TaskId = 102, TaskName = "Competency Evaluation", Details = "Finding resources required for the project.", AssignTo = "Sachin", TaskAssignDate = new DateTime(2022, 2, 16) });
            Add(new JobTask() { TaskId = 103, TaskName = "Project Planning", Details = "Planning the Implementation, team Size, etc.", AssignTo = "Veerat", TaskAssignDate = new DateTime(2022, 3, 12) });
        }
    }
}
