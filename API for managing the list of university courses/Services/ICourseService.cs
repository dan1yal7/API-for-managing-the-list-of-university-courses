using API_for_managing_the_list_of_university_courses.Models;
using Microsoft.EntityFrameworkCore;

namespace API_for_managing_the_list_of_university_courses.Services
{
    public interface ICourseService
    { 
        Course GetById(int id); 
        IEnumerable<Course> GetAll();    
        void Add(Course course); 
        void Update(Course course);
        void SaveChanges();
        void Delete(Course course); 
         
    } 

    public class CourseService : ICourseService
    {
        private readonly ApplicationDbContext _context; 
         private readonly DbSet<Course> _dbSet;  
         
        public CourseService(ApplicationDbContext context)
        { 
            _context = context; 
            _dbSet = _context.Set<Course>(); 
            
        } 

        public Course GetById(int id)
        {
            return _dbSet.SingleOrDefault(x => x.CourseId == id); 
        } 

        public IEnumerable<Course> GetAll()
        {
            return _dbSet.ToList(); 
        } 

        public void Add(Course course)
        { 
            _dbSet.Add(course); 
        } 
         
        public void Update(Course course)
        { 
           _context.Entry(course).State = EntityState.Modified; 
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        } 

        public void Delete (Course course)
        {
            _dbSet.Remove(course);
        }
         
    }
}
