namespace ViewWPost.Models
{
    public class Course
    {
        public int Id { get; set; }
        public static int IdCount { get; set; }
        public static List<Course> AllCourses { get; set; }
        public string Title { get; set; }
        public int Capacity { get; set; }
        public List<Registration> Registrations { get; set; }

        public Course(string title, int capacity)
        {
            Id = IdCount++;
            Title = title;
            Capacity = capacity;
            Registrations = new List<Registration>();  // 每门课都需要被注册
        }
        static Course()   // 玲姐提问：static 这个结构只出现一次 在一开始时候
        {
            AllCourses = new List<Course>();
        }

    }

}
