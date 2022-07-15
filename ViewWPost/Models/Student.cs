namespace ViewWPost.Models
{
    public class Student
    {
        public int Id { get; set; }
        public static int IdCount { get; set; } = 0;
        public static List<Student> AllStudents { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Registration>? Registrations { get; set; }

        public Student(string firstName, string lastName)
        {   
            Id = IdCount++;
            FirstName = firstName;
            LastName = lastName;
            Registrations = new List<Registration>();
        }

        static Student()
        {
            AllStudents = new List<Student>();
        }
    }
}
