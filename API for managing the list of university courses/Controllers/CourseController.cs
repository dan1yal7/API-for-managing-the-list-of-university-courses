using API_for_managing_the_list_of_university_courses.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_for_managing_the_list_of_university_courses.Controllers
{
    public class CourseController : Controller
    {

        private readonly ICourseService _courseservice; 

        public CourseController(ICourseService courseservice)
        {
            _courseservice = courseservice;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
