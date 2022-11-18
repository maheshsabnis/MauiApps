﻿namespace MAUI_RESTClient.Models
{
    public class JobTasks
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; } = null!;
        public string AssignedTo { get; set; } = null!;
        public DateTime AssignedDate { get; set; }
    }
}
