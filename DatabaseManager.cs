using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using DocumentFormat.OpenXml.Math;
using System.Threading.Tasks;

namespace student_enrolled
{



    class DatabaseManager
    {
        DataBase Base = new DataBase();
        public void Main()
        {
            string m = @"-- Insert records for 5 students
INSERT INTO [dbo].[students] ([name], [phone], [email], [day])
VALUES
    ('Student 1', '123-456-7890', 'student1@example.com', '2023-09-26'),
    ('Student 2', '987-654-3210', 'student2@example.com', '2023-09-26'),
    ('Student 3', '111-222-3333', 'student3@example.com', '2023-09-26'),
    ('Student 4', '444-555-6666', 'student4@example.com', '2023-09-26'),
    ('Student 5', '777-888-9999', 'student5@example.com', '2023-09-26');

-- Insert records for 2 courses
INSERT INTO [dbo].[courses] ([name], [price], [note], [day])
VALUES
    ('Course A', 100.00, 'Course A Description', '2023-09-26'),
    ('Course B', 150.00, 'Course B Description', '2023-09-26');

-- Enroll students in courses
-- Student 1 enrolls in Course A
INSERT INTO [dbo].[stud_enroll] ([stud_id], [course_id], [paid_price], [still], [day])
VALUES
    (1, 1, 100.00, 0.00, '2023-09-26');

-- Student 2 enrolls in Course A
INSERT INTO [dbo].[stud_enroll] ([stud_id], [course_id], [paid_price], [still], [day])
VALUES
    (2, 1, 100.00, 0.00, '2023-09-26');

-- Student 3 enrolls in Course A
INSERT INTO [dbo].[stud_enroll] ([stud_id], [course_id], [paid_price], [still], [day])
VALUES
    (3, 1, 100.00, 0.00, '2023-09-26');

-- Student 4 enrolls in Course B
INSERT INTO [dbo].[stud_enroll] ([stud_id], [course_id], [paid_price], [still], [day])
VALUES
    (4, 2, 150.00, 0.00, '2023-09-26');

-- Student 5 enrolls in Course B
INSERT INTO [dbo].[stud_enroll] ([stud_id], [course_id], [paid_price], [still], [day])
VALUES
    (5, 2, 150.00, 0.00, '2023-09-26');
";
            string studentQuery = "INSERT INTO students (name, phone, email, day) VALUES (@name, @phone, @email, @day);";
            string courseQuery = "INSERT INTO courses (name, price, note, day) VALUES (@name, @price, @note, @day);";
            string studEnrollQuery = "INSERT INTO stud_enroll (stud_id, course_id, paid_price, still, day) VALUES (@stud_id, @course_id, @paid_price, @still, @day);";

            // Set the number of records you want to generate
            int numRecords = 20; // You can change this as needed

            // Create Faker data for students, courses, and stud_enroll
            var studentFaker = new Faker<Studentfaker>()
                .RuleFor(s => s.Name, f => f.Name.FullName())
                .RuleFor(s => s.Phone, f => f.Phone.PhoneNumber())
                .RuleFor(s => s.Email, f => f.Internet.Email())
                .RuleFor(s => s.Day, f => f.Date.Past(2));

            var courseFaker = new Faker<Course>()
                .RuleFor(c => c.Name, f => f.Commerce.ProductName())
                .RuleFor(c => c.Price, f => f.Finance.Amount(10, 1000))
                .RuleFor(c => c.Note, f => f.Lorem.Sentence())
                .RuleFor(c => c.Day, f => f.Date.Past(1));

            var studEnrollFaker = new Faker<StudEnroll>()
                .RuleFor(se => se.StudId, f => f.Random.Number(1, numRecords)) // Assuming student IDs start from 1
                .RuleFor(se => se.CourseId, f => f.Random.Number(1, numRecords)) // Assuming course IDs start from 1
                .RuleFor(se => se.PaidPrice, f => f.Finance.Amount(0, 500))
                .RuleFor(se => se.Still, f => f.Finance.Amount(0, 500))
                .RuleFor(se => se.Day, f => f.Date.Past(1));

            // Generate and insert data in a loop
            for (int i = 0; i < numRecords; i++)
            {
                // Generate student data
                Studentfaker student = studentFaker.Generate();

                // Create student parameters
                SqlParameter[] studentParameters = new SqlParameter[]
                {
        new SqlParameter("@name", SqlDbType.NVarChar) { Value = student.Name },
        new SqlParameter("@phone", SqlDbType.VarChar) { Value = student.Phone },
        new SqlParameter("@email", SqlDbType.VarChar) { Value = student.Email },
        new SqlParameter("@day", SqlDbType.DateTime) { Value = student.Day }
                };
                 Task.Delay(4000);

                // Insert student data
                Base.ServerSendDataTable(studentQuery, studentParameters);
                Task.Delay(4000);

            }
            for (int i = 0; i < numRecords; i++)
            {
                // Generate course data
                Course course = courseFaker.Generate();

                // Create course parameters
                SqlParameter[] courseParameters = new SqlParameter[]
                {
        new SqlParameter("@name", SqlDbType.NVarChar) { Value = course.Name },
        new SqlParameter("@price", SqlDbType.Decimal) { Value = course.Price },
        new SqlParameter("@note", SqlDbType.NVarChar) { Value = course.Note },
        new SqlParameter("@day", SqlDbType.Date) { Value = course.Day }
                };
                Task.Delay(4000);

                // Insert course data

                Base.ServerSendDataTable(courseQuery, courseParameters);
                Task.Delay(4000);

            }

                for (int i = 0; i < numRecords; i++)
                {
                    // Generate stud_enroll data
                    StudEnroll studEnroll = studEnrollFaker.Generate();

                    // Create stud_enroll parameters
                    SqlParameter[] studEnrollParameters = new SqlParameter[]
                    {
        new SqlParameter("@stud_id", SqlDbType.Int) { Value = i },
        new SqlParameter("@course_id", SqlDbType.Int) { Value = studEnroll.CourseId },
        new SqlParameter("@paid_price", SqlDbType.Decimal) { Value = studEnroll.PaidPrice },
        new SqlParameter("@still", SqlDbType.Decimal) { Value = studEnroll.Still },
        new SqlParameter("@day", SqlDbType.Date) { Value = studEnroll.Day }
                    };
                    Task.Delay(8000);

                    // Insert stud_enroll data
                    Base.ServerSendDataTable(studEnrollQuery, studEnrollParameters);
                    Task.Delay(8000);

                }
            


        }
    }

    class Studentfaker
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime Day { get; set; }
    }

    class Course
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Note { get; set; }
        public DateTime Day { get; set; }
    }

    class StudEnroll
    {
        public int StudId { get; set; }
        public int CourseId { get; set; }
        public decimal PaidPrice { get; set; }
        public decimal Still { get; set; }
        public DateTime Day { get; set; }
    }

}
