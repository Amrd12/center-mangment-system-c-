using Bogus.DataSets;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_enrolled.forms.attendance
{
    internal class Studentattend
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Paid { get; set; }
        public decimal Still { get; set; }
        public bool Attended { get; set; }
        public int absent { get; set; }
        public List<Studentattend> GetALLStudentsByCourse(int courseId)
        {
            string query = @"
            SELECT s.id AS student_id, s.name AS student_name, se.paid_price AS paid, se.still
            FROM stud_enroll se
            INNER JOIN students s ON se.stud_id = s.id
            WHERE se.course_id = @CourseId;
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@CourseId", SqlDbType.Int) { Value = courseId },
            };

            DataTable studentDataTable = new DataBase().ServerGetDataTable(query, parameters);

            List<Studentattend> studentList = new List<Studentattend>();

            foreach (DataRow row in studentDataTable.Rows)
            {
                Studentattend student = new Studentattend
                {
                    ID = Convert.ToInt32(row["student_id"]),
                    Name = row["student_name"].ToString(),
                    Paid = Convert.ToDecimal(row["paid"]),
                    Still = Convert.ToDecimal(row["still"]),
                    Attended = false
                };
                studentList.Add(student);
            }

            return studentList;
        }
        public Studentattend student(int courseId , int student_id , int attend_id)
        {
            string query = @"
SELECT 
    a.id,
    s.id AS student_id,
    s.name AS student_name,
    se.paid_price AS paid,
    se.still,
    c.absent,
    a.attended,
    (
        SELECT COUNT(sa.id)
        FROM dbo.student_attendance AS sa
        INNER JOIN dbo.stud_enroll AS se_inner ON sa.student_id = se_inner.stud_id
        WHERE sa.student_id = s.id
        AND sa.attended = 0
        AND se_inner.course_id = se.course_id
    ) AS absent_number
FROM 
    dbo.student_attendance AS a
LEFT JOIN 
    dbo.students AS s ON a.student_id = s.id
LEFT JOIN 
    dbo.stud_enroll AS se ON s.id = se.stud_id
LEFT JOIN 
    dbo.courses AS c ON se.course_id = c.id
WHERE
    c.id = @courseId AND s.id=@id AND  a.attendance_id = @attend_id;
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@CourseId", SqlDbType.Int) { Value = courseId },
                        new SqlParameter("@id", SqlDbType.Int) { Value = student_id },
                                     new SqlParameter("@attend_id", SqlDbType.Int) { Value = attend_id },

            };

            DataTable studentDataTable = new DataBase().ServerGetDataTable(query, parameters);
            Studentattend onestudent  =new Studentattend();

            foreach (DataRow row in studentDataTable.Rows)
            {
                onestudent = new Studentattend
                {
                    ID = Convert.ToInt32(row["student_id"]),
                    Name = row["student_name"].ToString(),
                    Paid = Convert.ToDecimal(row["paid"]),
                    Still = Convert.ToDecimal(row["still"]),
                };
                if ((int)row["absent"] <= (int)row["absent_number"])
                    return null;
                else if (onestudent.Attended == true) // <-- Corrected line
                    onestudent.Attended = true;
                else
                    onestudent.Attended= false;
            }

            return onestudent;
        }
        public Dictionary<string, List<Studentattend>> GetAttendAndAbsendStudents( int attend_id)
        {
            string query = @"
SELECT 
    a.id,
    s.id AS student_id,
    s.name AS student_name,
    se.paid_price AS paid,
    se.still,
    c.absent,
    a.attended,
    (
        SELECT COUNT(sa.id)
        FROM dbo.student_attendance AS sa
        INNER JOIN dbo.stud_enroll AS se_inner ON sa.student_id = se_inner.stud_id
        WHERE sa.student_id = s.id
        AND sa.attended = 0
        AND se_inner.course_id = se.course_id
    ) AS absent_number
FROM 
    dbo.student_attendance AS a
LEFT JOIN 
    dbo.students AS s ON a.student_id = s.id
LEFT JOIN 
    dbo.stud_enroll AS se ON s.id = se.stud_id
LEFT JOIN 
    dbo.courses AS c ON se.course_id = c.id
WHERE
    a.attendance_id = @attend_id;
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
             new SqlParameter("@attend_id", SqlDbType.Int) { Value = attend_id },

            };

            DataTable studentDataTable = new DataBase().ServerGetDataTable(query, parameters);
            studentDataTable.Columns["attended"].DataType = typeof(Boolean);
            studentDataTable.Columns["attended"].DefaultValue = false;
            List<Studentattend> studentbanned = new List<Studentattend>();

            List<Studentattend> studentaddented = new List<Studentattend>();
            List<Studentattend> studentabsent = new List<Studentattend>();

            foreach (DataRow row in studentDataTable.Rows)
            {
                if (Convert.IsDBNull(row["attended"]))
                    row["attended"] = false;
                Studentattend student = new Studentattend()
                {
                    ID = Convert.ToInt32(row["student_id"]),
                    Name = row["student_name"].ToString(),
                    Paid = Convert.ToDecimal(row["paid"]),
                    Still = Convert.ToDecimal(row["still"]),
                    Attended = Convert.ToBoolean(row["attended"]),
                    absent = Convert.ToInt32(row["absent_number"]),
                };
                if ((int)row["absent"] <= student.absent)
                    studentbanned.Add(student);
                else if (student.Attended == true) // <-- Corrected line
                    studentaddented.Add(student);
                else
                    studentabsent.Add(student);
            }

            Dictionary<string, List<Studentattend>> keyValuePairs = new Dictionary<string, List<Studentattend>>();
            keyValuePairs.Add("attended", studentaddented);
            keyValuePairs.Add("banned", studentbanned);
            keyValuePairs.Add("absent", studentabsent);

            return keyValuePairs;
        }
        public void student_save(Studentattend st, int id)
        {
            string querry = "UPDATE student_attendance SET attended = @attended " +
                           "WHERE attendance_id = @attendanceId AND student_id = @studentId";
            int bitValue = st.Attended ? 1 : 0;

            SqlParameter[] parameters = new SqlParameter[]{
                new SqlParameter("@attendanceId", SqlDbType.Int) { Value = id },
                new SqlParameter("@studentId", SqlDbType.Int) { Value = st.ID },
                new SqlParameter("@attended", SqlDbType.Bit) { Value =bitValue}
            };
            new DataBase().ServerSendDataTable(querry , parameters);
        }


    }
}
