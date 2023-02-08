using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkPractice.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Description", "DischargeDate", "Name" },
                values: new object[] { 1, "Estatus de registro generico para todas las tablas que usan", new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4532), "Creado" });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Description", "DischargeDate", "Name" },
                values: new object[] { 2, "Estatus de registro generico para todas las tablas que usan", new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4541), "Activo" });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Description", "DischargeDate", "Name" },
                values: new object[] { 3, "Estatus de registro generico para todas las tablas que usan", new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4541), "Inactivo" });

            migrationBuilder.InsertData(
                table: "Profesors",
                columns: new[] { "Id", "DischargeDate", "FirstName", "LastName", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4596), "Steven1", "Mendez1", 1 },
                    { 2, new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4597), "Steven2", "Mendez2", 2 },
                    { 3, new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4598), "Steven3", "Mendez3", 3 },
                    { 4, new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4599), "Steven4", "Mendez4", 1 },
                    { 5, new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4599), "Steven5", "Mendez5", 2 },
                    { 6, new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4600), "Steven6", "Mendez6", 3 },
                    { 7, new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4600), "Steven7", "Mendez7", 1 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "BirthDate", "DischargeDate", "FirstName", "MaternalSurname", "PaternalSurname", "StatusId" },
                values: new object[,]
                {
                    { 1, new DateTime(2003, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4612), new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4611), "Student1", "Student111", "Student11", 1 },
                    { 2, new DateTime(2003, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4619), new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4619), "Student2", "Student111", "Student11", 2 },
                    { 3, new DateTime(2003, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4620), new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4620), "Student3", "Student111", "Student11", 3 },
                    { 4, new DateTime(2003, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4622), new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4621), "Student4", "Student111", "Student11", 1 },
                    { 5, new DateTime(2003, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4647), new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4645), "Student5", "Student111", "Student11", 2 },
                    { 6, new DateTime(2003, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4649), new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4648), "Student6", "Student111", "Student11", 1 }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "DischargeDate", "Name", "Objective", "ProfesorId", "StatusId" },
                values: new object[,]
                {
                    { 1, "Descripcion1", new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4657), "Course1", "Objective1", 1, 1 },
                    { 2, "Descripcion2", new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4658), "Course2", "Objective2", 2, 2 },
                    { 3, "Descripcion3", new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4659), "Course3", "Objective3", 3, 3 },
                    { 4, "Descripcion4", new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4660), "Course4", "Objective4", 4, 1 },
                    { 5, "Descripcion5", new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4660), "Course5", "Objective5", 5, 2 },
                    { 6, "Descripcion6", new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4661), "Course6", "Objective6", 6, 3 },
                    { 7, "Descripcion7", new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4662), "Course7", "Objective7", 7, 1 },
                    { 8, "Descripcion8", new DateTime(2023, 2, 8, 16, 54, 37, 638, DateTimeKind.Local).AddTicks(4662), "Course8", "Objective8", 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "CoursesStudents",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CoursesStudents",
                keyColumns: new[] { "CourseId", "StudentId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Profesors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Profesors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Profesors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Profesors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Profesors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profesors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profesors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
