using API_for_managing_the_list_of_university_courses.Models;
using Microsoft.EntityFrameworkCore;

namespace API_for_managing_the_list_of_university_courses.Services
{
    public interface IScheduleService
    {
        Schedule GetById(int id); 
        IEnumerable<Schedule> GetAll();
        void Add (Schedule schedule);
        void Update (Schedule schedule);
        void SaveChanges(); 
        void Delete(Schedule schedule);

    } 

    public class ScheduleService: IScheduleService
    {
        private readonly ApplicationDbContext _context; 
        private readonly DbSet<Schedule> _dbSet; 


        public ScheduleService(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Schedule>();
        }  

        public Schedule GetById(int id)
        {
            return _dbSet.Find(id);
        } 

        public IEnumerable<Schedule> GetAll()
        {
             return _dbSet.ToList();
        } 


        public void Add(Schedule schedule)
        { 
            _dbSet.Add(schedule);
        }  

        public void Update (Schedule schedule)
        {
           _context.Entry(schedule).State = EntityState.Modified;
        } 

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Delete(Schedule schedule)
        {
              _dbSet.Remove(schedule);
        }
    }


}
