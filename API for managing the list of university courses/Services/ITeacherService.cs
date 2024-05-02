using API_for_managing_the_list_of_university_courses.Models;
using Microsoft.EntityFrameworkCore;

namespace API_for_managing_the_list_of_university_courses.Services
{
    public interface ITeacherService
    { 
        Teacher GetById(int id); 
        IEnumerable<Teacher> GetAll(); 
        void Add(Teacher teacher); 
        void Update (Teacher teacher); 
        void SaveChanges (); 
        void Delete (Teacher teacher); 
    } 

    public class TeacherService : ITeacherService
    {
        private readonly ApplicationDbContext _context; 
        private readonly DbSet<Teacher> _dbSet; 


        public TeacherService(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Teacher>(); 
        } 

        public Teacher GetById(int id)
        {
            return _dbSet.SingleOrDefault(t => t.TeacherId == id);
        } 

        public IEnumerable<Teacher> GetAll()
        {
            return _dbSet.ToList(); 
        } 

        public void Add(Teacher teacher)
        {
            _dbSet.Add(teacher);
        }
        public void Update(Teacher teacher)
        {
            _context.Entry(teacher).State = EntityState.Modified;
        }   

        public void SaveChanges()
        {
            _context.SaveChanges();
        } 

        public void Delete (Teacher teacher)
        {
            _dbSet.Remove(teacher); 
        }

            
    }  

 
}
