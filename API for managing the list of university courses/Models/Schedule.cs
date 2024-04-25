namespace API_for_managing_the_list_of_university_courses.Models
{
    public class Schedule
    { 
        public int Id { get; set; } 
        public int CourseId { get; set; }  
        public DayOfWeek DayOfWeek { get; set; } 
        public DateTime StarTime { get; set; } 
        public DateTime EndTime { get; set; }  
        public string ClassType { get; set; } 
        public int auditorium {  get; set; } 


        
    }

    public enum DayofWeek
    {
        Monday, 
        Tuesday, 
        Wednesday,
        Thursday, 
        Friday, 
        Saturday
    }
}
