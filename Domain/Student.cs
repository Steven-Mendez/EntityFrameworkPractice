namespace EntityFrameworkPractice.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? PaternalSurname { get; set; }
        public string? MaternalSurname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DischargeDate { get; set; }

        public int StatusId { get; set; }
        public Status? Status { get; set; }

        public IEnumerable<CoursesStudents>? CoursesStudents { get; set; }
    }
}
