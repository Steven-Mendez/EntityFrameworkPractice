namespace EntityFrameworkPractice.Domain
{
    public class Profesor
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DischargeDate { get; set; }

        public int StatusId { get; set; }
        public Status? Status { get; set; }

        public IEnumerable<Course>? Courses { get; set; }
    }
}
