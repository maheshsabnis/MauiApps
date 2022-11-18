namespace DataService.Models
{
    public class JobTasks
    {
        public int TaskId { get; set; }
        public string? TaskName { get; set; }
        public string? AssignTo { get; set; }
        public DateTime AssignDate { get; set; }
    }
}
