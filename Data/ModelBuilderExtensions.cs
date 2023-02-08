using EntityFrameworkPractice.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkPractice.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>()
                .HasData(
                new Status { Id = 1, Name = "Creado", Description = "Estatus de registro generico para todas las tablas que usan", DischargeDate = DateTime.Now },
                new Status { Id = 2, Name = "Activo", Description = "Estatus de registro generico para todas las tablas que usan", DischargeDate = DateTime.Now },
                new Status { Id = 3, Name = "Inactivo", Description = "Estatus de registro generico para todas las tablas que usan", DischargeDate = DateTime.Now }
                );

            modelBuilder.Entity<Profesor>()
                .HasData(
                new Profesor { Id = 1, FirstName = "Steven1", LastName = "Mendez1", DischargeDate = DateTime.Now, StatusId = 1 },
                new Profesor { Id = 2, FirstName = "Steven2", LastName = "Mendez2", DischargeDate = DateTime.Now, StatusId = 2 },
                new Profesor { Id = 3, FirstName = "Steven3", LastName = "Mendez3", DischargeDate = DateTime.Now, StatusId = 3 },
                new Profesor { Id = 4, FirstName = "Steven4", LastName = "Mendez4", DischargeDate = DateTime.Now, StatusId = 1 },
                new Profesor { Id = 5, FirstName = "Steven5", LastName = "Mendez5", DischargeDate = DateTime.Now, StatusId = 2 },
                new Profesor { Id = 6, FirstName = "Steven6", LastName = "Mendez6", DischargeDate = DateTime.Now, StatusId = 3 },
                new Profesor { Id = 7, FirstName = "Steven7", LastName = "Mendez7", DischargeDate = DateTime.Now, StatusId = 1 }
                );
            modelBuilder.Entity<Student>()
                .HasData(
                new Student { Id = 1, FirstName = "Student1", PaternalSurname = "Student11", MaternalSurname = "Student111", DischargeDate = DateTime.Now, BirthDate = DateTime.Now.AddYears(-20), StatusId = 1 },
                new Student { Id = 2, FirstName = "Student2", PaternalSurname = "Student11", MaternalSurname = "Student111", DischargeDate = DateTime.Now, BirthDate = DateTime.Now.AddYears(-20), StatusId = 2 },
                new Student { Id = 3, FirstName = "Student3", PaternalSurname = "Student11", MaternalSurname = "Student111", DischargeDate = DateTime.Now, BirthDate = DateTime.Now.AddYears(-20), StatusId = 3 },
                new Student { Id = 4, FirstName = "Student4", PaternalSurname = "Student11", MaternalSurname = "Student111", DischargeDate = DateTime.Now, BirthDate = DateTime.Now.AddYears(-20), StatusId = 1 },
                new Student { Id = 5, FirstName = "Student5", PaternalSurname = "Student11", MaternalSurname = "Student111", DischargeDate = DateTime.Now, BirthDate = DateTime.Now.AddYears(-20), StatusId = 2 },
                new Student { Id = 6, FirstName = "Student6", PaternalSurname = "Student11", MaternalSurname = "Student111", DischargeDate = DateTime.Now, BirthDate = DateTime.Now.AddYears(-20), StatusId = 1 }
                );
            modelBuilder.Entity<Course>()
                .HasData(
                new Course { Id = 1, Name = "Course1", Description = "Descripcion1", Objective = "Objective1", DischargeDate = DateTime.Now, ProfesorId = 1, StatusId = 1 },
                new Course { Id = 2, Name = "Course2", Description = "Descripcion2", Objective = "Objective2", DischargeDate = DateTime.Now, ProfesorId = 2, StatusId = 2 },
                new Course { Id = 3, Name = "Course3", Description = "Descripcion3", Objective = "Objective3", DischargeDate = DateTime.Now, ProfesorId = 3, StatusId = 3 },
                new Course { Id = 4, Name = "Course4", Description = "Descripcion4", Objective = "Objective4", DischargeDate = DateTime.Now, ProfesorId = 4, StatusId = 1 },
                new Course { Id = 5, Name = "Course5", Description = "Descripcion5", Objective = "Objective5", DischargeDate = DateTime.Now, ProfesorId = 5, StatusId = 2 },
                new Course { Id = 6, Name = "Course6", Description = "Descripcion6", Objective = "Objective6", DischargeDate = DateTime.Now, ProfesorId = 6, StatusId = 3 },
                new Course { Id = 7, Name = "Course7", Description = "Descripcion7", Objective = "Objective7", DischargeDate = DateTime.Now, ProfesorId = 7, StatusId = 1 },
                new Course { Id = 8, Name = "Course8", Description = "Descripcion8", Objective = "Objective8", DischargeDate = DateTime.Now, ProfesorId = 1, StatusId = 2 }
                );
            modelBuilder.Entity<CoursesStudents>()
                .HasData(
                new CoursesStudents { CourseId = 1, StudentId = 1 },
                new CoursesStudents { CourseId = 1, StudentId = 2 },
                new CoursesStudents { CourseId = 1, StudentId = 3 },
                new CoursesStudents { CourseId = 1, StudentId = 4 },
                new CoursesStudents { CourseId = 1, StudentId = 5 },
                new CoursesStudents { CourseId = 2, StudentId = 1 },
                new CoursesStudents { CourseId = 2, StudentId = 2 },
                new CoursesStudents { CourseId = 2, StudentId = 3 },
                new CoursesStudents { CourseId = 2, StudentId = 4 },
                new CoursesStudents { CourseId = 2, StudentId = 5 },
                new CoursesStudents { CourseId = 3, StudentId = 1 },
                new CoursesStudents { CourseId = 3, StudentId = 2 },
                new CoursesStudents { CourseId = 3, StudentId = 3 }
                );
        }
    }
}
