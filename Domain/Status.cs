namespace EntityFrameworkPractice.Domain
{
    public class Status
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DischargeDate { get; set; }

        public IEnumerable<Profesor>? Profesors { get; set; }
        public IEnumerable<Student>? Students { get; set; }
        public IEnumerable<Course>? Courses { get; set; }
    }
}
