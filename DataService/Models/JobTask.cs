﻿using System;
using System.Collections.Generic;

namespace DataService.Models
{
    public partial class JobTask
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; } = null!;
        public string AssignedTo { get; set; } = null!;
        public DateTime AssignedDate { get; set; }
    }
}
