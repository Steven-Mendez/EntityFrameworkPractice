namespace EntityFrameworkPractice.Domain
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Objective { get; set; }
        public DateTime DischargeDate { get; set; }

        public int StatusId { get; set; }
        public Status? Status { get; set; }

        public int ProfesorId { get; set; }
        public Profesor? Profesor { get; set; }

        public IEnumerable<CoursesStudents>? CoursesStudents { get; set; }
    }
}
