using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_enrolled.forms
{
    public partial class home : Form
    {
        DateTime startdate;
        DateTime enddate;
        bool alltime = true;
        int course=-1;
        public home()
        {
            InitializeComponent();
            fillform();


        }

        static DataBase Base = new DataBase();
        private void fillform()
        {
            clearcharts();
            filllab();
            fillmoney();
            fillpanel();
            fillchart();
        }
        private void clearcharts()
        {
            chartdays.Series[1].Points.Clear();
            chartdays.Series[0].Points.Clear();
            chartmoney.Series[0].Points.Clear();

        }

        private void filllab()
        {
            DataTable dt;
            if (alltime)
            {
                string query =
                @"
 SELECT
    (SELECT COUNT(*) FROM students) AS TotalStudents,
    (SELECT COUNT(*) FROM courses) AS TotalCourses,
    (SELECT COUNT(*) FROM stud_enroll) AS TotalEnrolls

            ";
                 dt = Base.ServerGetDataTable(query, new System.Data.SqlClient.SqlParameter[0]);
            }
            else
            {
                string query =
@"
SELECT
    (SELECT COUNT(*) FROM students WHERE day >= @StartDate AND day <= @EndDate) AS TotalStudents,
    (SELECT COUNT(*) FROM courses WHERE day >= @StartDate AND day <= @EndDate) AS TotalCourses,
    (SELECT COUNT(*) FROM stud_enroll WHERE day >= @StartDate AND day <= @EndDate) AS TotalEnrolls

            ";
                SqlParameter[] parameters = new SqlParameter[]
    {
                new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = startdate },
                new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = enddate },

    };
                 dt = Base.ServerGetDataTable(query, parameters);
            }
            lbstudents.Text = dt.Rows[0]["TotalStudents"].ToString();
            lbcourses.Text = dt.Rows[0]["TotalCourses"].ToString();
            lbenrolls.Text = dt.Rows[0]["TotalEnrolls"].ToString();

        }
        private void fillmoney()
        {
            DataTable dt;
            if (alltime)
            {
                if (course == -1)
                {
                    string query = @"
SELECT
    SUM(se.paid_price) AS TotalPaid,
    SUM(se.still) AS TotalStill,
    SUM(c.price) AS TotalCoursePrice
FROM
    stud_enroll se
    JOIN courses c ON se.course_id = c.id;
";
                    dt = Base.ServerGetDataTable(query, new System.Data.SqlClient.SqlParameter[0]);
                }
                else
                {
                    string query = @"
SELECT 
    SUM(se.paid_price) AS TotalPaid, 
    SUM(se.still) AS TotalStill,
    SUM(c.price) AS TotalCoursePrice
FROM    
    stud_enroll se
    JOIN courses c ON se.course_id = c.id
WHERE 
    se.course_id = @CourseId;
";
                    dt = Base.ServerGetDataTable(query, new System.Data.SqlClient.SqlParameter[] { new SqlParameter("@CourseId", SqlDbType.Int) { Value = course } });

                }
            }
            else
            {
                if (course == -1)
                {
                    string query = @"
SELECT
    SUM(se.paid_price) AS TotalPaid,
    SUM(se.still) AS TotalStill,
    SUM(c.price) AS TotalCoursePrice
FROM
    stud_enroll se
    JOIN courses c ON se.course_id = c.id
WHERE
    se.day >= @StartDate AND se.day <= @EndDate;
";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = startdate },
                new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = enddate },
                    };
                    dt = Base.ServerGetDataTable(query, parameters);
                }
                else
                {
                    string query = @"
SELECT
    SUM(se.paid_price) AS TotalPaid,
    SUM(se.still) AS TotalStill,
    SUM(c.price) AS TotalCoursePrice
FROM
    stud_enroll se
    JOIN courses c ON se.course_id = c.id
WHERE
    se.day >= @StartDate AND se.day <= @EndDate AND se.course_id = @CourseId;
";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = startdate },
                new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = enddate },
                new SqlParameter("@CourseId", SqlDbType.Int) { Value = course },
                    };
                    dt = Base.ServerGetDataTable(query, parameters);

                }
            }
            chartmoney.Series[0].Points.AddXY("Paid", dt.Rows[0]["TotalPaid"].ToString());
            chartmoney.Series[0].Points.AddXY("Still", dt.Rows[0]["TotalStill"].ToString());
           // chartmoney.Series[0].Points.AddXY("Total Course Price", dt.Rows[0]["TotalCoursePrice"].ToString());

            lbpaid.Text = "total paid:  " + dt.Rows[0]["TotalPaid"].ToString();
            lbstill.Text = "total still:  " + dt.Rows[0]["TotalStill"].ToString();
            lbtotal.Text = "total:  " + dt.Rows[0]["TotalCoursePrice"].ToString();
        }

        private void fillchart()
        {
            DataTable dt;
            if (alltime)
            {
                if (course == -1)
                {
                    string query = @"
                SELECT day, SUM(paid_price) AS PaidAmount, SUM(still) AS StillAmount
                FROM stud_enroll
                GROUP BY day
                ";
                    dt = Base.ServerGetDataTable(query, new System.Data.SqlClient.SqlParameter[0]);
                }
                else
                {
                    string query = @"
                SELECT day, SUM(paid_price) AS PaidAmount, SUM(still) AS StillAmount
                FROM stud_enroll
                WHERE  course_id=@CourseId
                GROUP BY day
                ";
                    dt = Base.ServerGetDataTable(query, new System.Data.SqlClient.SqlParameter[] { new SqlParameter("@CourseId", SqlDbType.Int) { Value = course } });
                }
            }
            else
            {
                if (course == -1)
                {
                    string query =
                    @"
                SELECT day, SUM(paid_price) AS PaidAmount, SUM(still) AS StillAmount
                FROM stud_enroll
                WHERE day >= @StartDate AND day <= @EndDate 
                GROUP BY day

                ";
                    SqlParameter[] parameters = new SqlParameter[]
         {
                new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = startdate },
                new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = enddate },

         };
                    dt = Base.ServerGetDataTable(query, parameters);
                }
                else
                {
                    string query =
                    @"
                SELECT day, SUM(paid_price) AS PaidAmount, SUM(still) AS StillAmount
                FROM stud_enroll
                WHERE day >= @StartDate AND day <= @EndDate AND course_id=@CourseId
                GROUP BY day

                ";
                    SqlParameter[] parameters = new SqlParameter[]
         {
                new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = startdate },
                new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = enddate },
                new SqlParameter("@CourseId", SqlDbType.Int) { Value = course }

         };
                    dt = Base.ServerGetDataTable(query, parameters);
                }
            }
            foreach (DataRow row in dt.Rows)
            {
                string date = row[0].ToString();
                decimal paidAmount = Convert.ToDecimal(row[1]);
                decimal stillAmount = Convert.ToDecimal(row[2]);

                chartdays.Series[0].Points.AddXY(date, paidAmount);
                chartdays.Series[1].Points.AddXY(date, stillAmount);
            }
        }

        private void fillpanel()
        {
            DataTable dt;
            if (alltime)
            {
                string query =
                    @"
SELECT
    c.id , c.name AS CourseName,  COUNT(*) AS UserCount
FROM
    courses c
INNER JOIN
    stud_enroll se ON c.id = se.course_id
GROUP BY
    c.id,
    c.name

                ";
                 dt = Base.ServerGetDataTable(query, new System.Data.SqlClient.SqlParameter[0]);
            }
            else
            {
                string query =
    @"
SELECT c.id, c.name AS CourseName, COUNT(*) AS UserCount
FROM courses c
INNER JOIN stud_enroll se ON c.id = se.course_id
WHERE se.day >= @StartDate AND se.day <= @EndDate
GROUP BY     c.id, c.name
                ";
               SqlParameter[] parameters = new SqlParameter[]
    {
                new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = startdate },
                new SqlParameter("@EndDate", SqlDbType.DateTime) { Value = enddate },

    };
                dt = Base.ServerGetDataTable(query, parameters);
            }
            dataGridView1.DataSource= dt;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].Visible= false;
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.CurrentRow;
            if(selectedRow!= null)
            {
                course = int.Parse(selectedRow.Cells[0].Value.ToString());
                clearcharts();
                fillmoney();
                fillchart();
                btnrefresh.Visible = true;
                btnrefresh.Text = "refresh \n" + selectedRow.Cells[1].Value.ToString();
            }
           
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            course = -1;
           // btnrefresh.Text = "refresh";
            btnrefresh.Visible = false;
            clearcharts();
            fillmoney();
            fillchart();
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            alltime = true;
            fillform();
        }
        private void btncustom_Click(object sender, EventArgs e)
        {
            if(DateStart == null && DateEnd == null) { MessageBox.Show("please select date"); return; }
            startdate = DateStart.Value; enddate = DateEnd.Value;
             alltime = false;
            fillform();
        }

        private void btnlast7_Click(object sender, EventArgs e)
        {
            enddate = DateTime.Today; startdate = DateTime.Now.AddDays(-7);
            DateStart.Value=startdate; DateEnd.Value=enddate;
            alltime = false;
            fillform();
        }

        private void btnlastmon_Click(object sender, EventArgs e)
        {
            enddate = DateTime.Today;
            startdate = DateTime.Now.AddMonths(-1);
            DateStart.Value = startdate; DateEnd.Value = enddate;

            alltime = false;
            fillform();
        }

        private void btnthismon_Click(object sender, EventArgs e)
        {
            int daysinmonth = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            startdate = DateTime.Now.AddDays(-DateTime.Today.Day+1);
            enddate = DateTime.Today.AddDays(daysinmonth - DateTime.Today.Day);
            DateStart.Value = startdate; DateEnd.Value = enddate;

            alltime = false;
            fillform();
        }
        private void btnenter(object sender, EventArgs e)
        {
            Button btnadd=null;
            btnadd = (Button)sender;
            btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(110)))), ((int)(((byte)(16)))));

        }
        private void btngo(object sender, EventArgs e)
        {
            Button btnadd = null;

            btnadd = (Button)sender;
            btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));

        }


    }

}
