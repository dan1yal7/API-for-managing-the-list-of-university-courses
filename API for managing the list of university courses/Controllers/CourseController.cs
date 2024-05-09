using API_for_managing_the_list_of_university_courses.Models;
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

        // GET: api/<CourseController> 
        [HttpGet] 
        public ActionResult GetAll()
        {
            var courses = _courseservice.GetAll(); 
            return Ok(courses);
        }

        // GET: api/<CourseController> 
        [HttpGet (template: "{id}")] 
        public ActionResult GetById(int id)
        {
            var coruse = _courseservice.GetById(id);
            return Ok(coruse);
        }


        [HttpPost] 

        public ActionResult Create(Course course)
        {
            if(!ModelState .IsValid)
            {

                return BadRequest(ModelState);
               
            }

            _courseservice.Add(course);
           _courseservice.SaveChanges(); 

           return CreatedAtAction(nameof(GetById), new { id = course.CourseId }, course);
        }
    }
}
