using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation_MVVM.Models
{
    public class JobTask
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public string Details { get; set; }
        public string AssignTo { get; set; }
        public DateTime TaskAssignDate { get; set; }
    }

   
}

