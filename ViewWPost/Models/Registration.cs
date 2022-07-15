namespace ViewWPost.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public static int IdCount { get; set; }
        public int? Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public static List<Registration> AllRegistrations { get; set; }
        public Registration(Student student, Course course)
        {
            Student = student;
            Course = course;
        }
        static Registration()
        {
            AllRegistrations = new List<Registration>();
        }
    }
}
