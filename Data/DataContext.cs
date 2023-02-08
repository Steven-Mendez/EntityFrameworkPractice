using EntityFrameworkPractice.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPractice.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Profesor> Profesors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CoursesStudents> CoursesStudents { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define primary key
            modelBuilder.Entity<CoursesStudents>()
                .HasKey(CoursesStudents => new { CoursesStudents.CourseId, CoursesStudents.StudentId });

            // Define relationships
            modelBuilder.Entity<CoursesStudents>()
                .HasOne<Course>(ce => ce.Course)
                .WithMany(Courses => Courses.CoursesStudents)
                .HasForeignKey(ce => ce.CourseId);

            modelBuilder.Entity<CoursesStudents>()
                .HasOne<Student>(std => std.Student)
                .WithMany(Courses => Courses.CoursesStudents)
                .HasForeignKey(std => std.StudentId);
        }
    }
}
