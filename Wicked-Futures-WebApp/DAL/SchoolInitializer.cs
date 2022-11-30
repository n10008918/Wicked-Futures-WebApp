using System;

using Microsoft.EntityFrameworkCore;
using Wicked_Futures_WebApp.Data;
using Wicked_Futures_WebApp.Models;

namespace Wicked_Futures_WebApp.DAL
{
    public static class SchoolInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any Student.
                if (context.Students.Any())
                {
                    return;   // DB has been seeded
                }

                context.Students.AddRange(
                    new Student { StudentID = 1, FirstName = "Carson", LastName = "Alexander" },
                    new Student { StudentID = 2, FirstName = "Arturo", LastName = "Anand" },
                    new Student { StudentID = 3, FirstName = "Arturo", LastName = "Anand" },
                    new Student { StudentID = 4, FirstName = "Gytis", LastName = "Barzdukas" },
                    new Student { StudentID = 5, FirstName = "Yan", LastName = "Li" },
                    new Student { StudentID = 6, FirstName = "Peggy", LastName = "Justice" },
                    new Student { StudentID = 7, FirstName = "Laura", LastName = "Norman" },
                    new Student { StudentID = 8, FirstName = "Nino", LastName = "Olivetto" });
                context.SaveChanges();



                //--

                // Look for any Course.
                if (context.Courses.Any())
                {
                    return;   // DB has been seeded
                }

                context.Courses.AddRange(
                    new Course { CourseID = 1050, Title = "Chemistry", Credits = 3 },
                    new Course { CourseID = 4022, Title = "Microeconomics", Credits = 3 },
                    new Course { CourseID = 4041, Title = "Macroeconomics", Credits = 3 },
                    new Course { CourseID = 1045, Title = "Calculus", Credits = 4 },
                    new Course { CourseID = 3141, Title = "Trigonometry", Credits = 4 },
                    new Course { CourseID = 2021, Title = "Composition", Credits = 3 },
                    new Course { CourseID = 2042, Title = "Literature", Credits = 4 });
                context.SaveChanges();

                //--






                // Look for any Enrollment.
                if (context.Enrollments.Any())
                {
                    return;   // DB has been seeded
                }

                context.Enrollments.AddRange(
                    new Enrollment { StudentID = 1, CourseID = 1050, Grade = Grade.A },
                    new Enrollment { StudentID = 1, CourseID = 4022, Grade = Grade.C },
                    new Enrollment { StudentID = 1, CourseID = 4041, Grade = Grade.B },
                    new Enrollment { StudentID = 2, CourseID = 1045, Grade = Grade.B },
                    new Enrollment { StudentID = 2, CourseID = 3141, Grade = Grade.F },
                    new Enrollment { StudentID = 2, CourseID = 2021, Grade = Grade.F },
                    new Enrollment { StudentID = 3, CourseID = 1050 },
                    new Enrollment { StudentID = 4, CourseID = 1050 },
                    new Enrollment { StudentID = 4, CourseID = 4022, Grade = Grade.F },
                    new Enrollment { StudentID = 5, CourseID = 4041, Grade = Grade.C },
                    new Enrollment { StudentID = 6, CourseID = 1045 },
                    new Enrollment { StudentID = 7, CourseID = 3141, Grade = Grade.A });
                context.SaveChanges();



            }
        }
    }
}

