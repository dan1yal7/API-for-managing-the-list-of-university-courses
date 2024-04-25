namespace API_for_managing_the_list_of_university_courses.Models
{
    public class Teacher
    { 
        public int  TeacherId { get; set; }
        public string Firstname { get; set; } 
        public string Lastname { get; set; } 
        public string Email { get; set; } 
        public string department { get; set; } 
        public string position { get; set; } 
        public int Cabinet {  get; set; }


    }
}
