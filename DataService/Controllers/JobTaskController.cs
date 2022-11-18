using DataService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DataService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobTaskController : ControllerBase
    {
        List<JobTasks> tasks=  new List<JobTasks> ();

        [HttpGet]
        public IActionResult Get()
        {
            if (HttpContext.Session.Keys.Count() > 0)
            {
                tasks = HttpContext.Session.GetObject<List<JobTasks>>("Tasks");
            }
            else
            {
                tasks = new List<JobTasks>();
            }
           
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult Post(JobTasks task)
        {
            if (HttpContext.Session.Keys.Count() == 0)
            {
                // add new task in the List
                tasks.Add(task);
                // Put Tasks in Session Object
                HttpContext.Session.SetObject<List<JobTasks>>("Tasks", tasks);
            }
            else
            {
                // Retrive the Task from the session
                tasks = HttpContext.Session.GetObject<List<JobTasks>>("Tasks");
                tasks.Add(task);
            }
            return Ok(tasks);
        }
    }
}
