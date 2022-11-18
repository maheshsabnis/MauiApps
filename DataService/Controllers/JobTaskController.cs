using DataService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTaskController : ControllerBase
    {
        List<JobTask> tasks=  new List<JobTask> ();
        TasksContext context;

        public JobTaskController(TasksContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            tasks = await context.JobTask.ToListAsync();
           
            return Ok(tasks);
        }

        [HttpPost]
        public async Task<IActionResult> Post(JobTask task)
        {
            var result = await context.JobTask.AddAsync(task);
            await context.SaveChangesAsync();
            return Ok(result.Entity);
        }
    }
}
