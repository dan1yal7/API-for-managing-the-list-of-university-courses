namespace API_for_managing_the_list_of_university_courses.Models
{
    public class Course
    { 
        public int CourseId { get; set; } 
        public string Name { get; set; } 
        public string Description { get; set; } 
        public int TeacherId { get; set; } 
        public string Dicipline { get; set; } 
        public int auditorium {  get; set; } 
        public int Semestr {  get; set; } 

    }
}
