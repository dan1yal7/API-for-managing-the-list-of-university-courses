using API_for_managing_the_list_of_university_courses.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_for_managing_the_list_of_university_courses.Controllers
{ 
     [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : Controller
    { 
        private readonly IScheduleService _scheduleService;
    
        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpGet("Getting Schedule")] 

        public ActionResult GetAll()
        {
           var schedule = _scheduleService.GetAll();     
            return Ok(schedule);
        }

        [HttpGet("GetById Schedule")]
        
        public ActionResult Get(int id)
        {
            var schedule = _scheduleService.GetById(id);
            return Ok(schedule);
        }
    }
}
