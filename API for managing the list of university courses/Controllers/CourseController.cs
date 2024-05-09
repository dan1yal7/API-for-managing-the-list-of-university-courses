using API_for_managing_the_list_of_university_courses.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_for_managing_the_list_of_university_courses.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseservice; 

        public CourseController(ICourseService courseservice)
        {
            _courseservice = courseservice;
        }
    }
}
