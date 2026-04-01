namespace University.Models
{
    public class Student
    {
        public int id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime Enrollmentdate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
