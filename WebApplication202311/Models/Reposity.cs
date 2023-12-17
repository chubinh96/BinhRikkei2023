namespace WebApplication202311.Models
{
    public static class Reposity
    {
        private static List<Student> _student = new List<Student>();

        public static List<Student> GetStudents()
        {
            return _student;
        }

        public static void AddStudent(Student student)
        {
            _student.Add(student);
        }

        public static void DeleteStudent(Student student)
        {
            //student.r
        }
    }
}
