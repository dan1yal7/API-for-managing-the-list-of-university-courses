using Microsoft.EntityFrameworkCore;

namespace API_for_managing_the_list_of_university_courses.Models
{
    public class ApplicationDbContext: DbContext
    { 
       public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Course> courses { get; set; }
        public DbSet<Teacher> teachers {  get; set; } 
        public DbSet<Schedule> schedules { get; set; }  

    }
}
