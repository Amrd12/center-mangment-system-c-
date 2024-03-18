
using DocumentFormat.OpenXml.Spreadsheet;
using student_enrolled.Properties;
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
using student_enrolled;

namespace student_enrolled.forms
{
    public partial class student : Form
    {
        private int id;
        private DataBase Base = new DataBase();
        DataTable studenttable;
        private int courseid=-1;
        public student(int id)
        {
            InitializeComponent();

            this.id = id;
            filllist();
            studenttable = Base.ServerGetDataTable($"SELECT * FROM students WHERE id = '{id}'",new SqlParameter[0]);
            txtname.Text = studenttable.Rows[0]["name"].ToString(); txtphone.Text = studenttable.Rows[0]["phone"].ToString();txtemail.Text = studenttable.Rows[0]["email"].ToString();
            lbjoin.Text += studenttable.Rows[0]["day"].ToString();
            // Create "Absent" and "Paid" columns with icons
            DataGridViewImageColumn absentColumn = new DataGridViewImageColumn();
            absentColumn.Name = "absentColumn";
            absentColumn.HeaderText = "Absent";
            absentColumn.ValueType = typeof(Bitmap);
            //absentColumn.Image = Properties.Resources.right;
            dataGridView1.Columns.Add(absentColumn);
            DataGridViewImageColumn paidColumn = new DataGridViewImageColumn();
            paidColumn.Name = "paidColumn";
            paidColumn.HeaderText = "Paid";
            paidColumn.ValueType = typeof(Bitmap);
            // paidColumn.Image = Properties.Resources._false;
            dataGridView1.Columns.Add(paidColumn);

        }
        private void addcol()
        {

            DataGridViewImageColumn deltemoney = new DataGridViewImageColumn();
            deltemoney.Name = "Delete";
            deltemoney.HeaderText = "Delete";
            deltemoney.Image = Resources.delete;
            Gridmoney.Columns.Add(deltemoney);
            DataGridViewImageColumn deletepay = new DataGridViewImageColumn();
            deletepay.Name = "Delete";
            deletepay.HeaderText = "Delete";
            deletepay.Image = Resources.delete;
            Gridabsent.Columns.Add(deletepay);

        }
        private void filllist()
        {
            string query = @"SELECT
        c.id,
        c.name AS course,
        c.absent,
        SUM(CASE WHEN sa.attended = 0 THEN 1 ELSE 0 END) AS total_absent,
        se.paid_price AS paid,
        se.still,
        se.id AS enroll_id
    FROM
        courses AS c
    INNER JOIN
        stud_enroll AS se ON c.id = se.course_id
    LEFT JOIN
        attendance AS a ON c.id = a.course_id
    LEFT JOIN
        student_attendance AS sa ON a.id = sa.attendance_id
    WHERE
        se.stud_id = @id
    GROUP BY
        c.id,
        c.name,
        c.absent,
        se.paid_price,
        se.still,
        se.id
    ";
            DataTable dt = Base.ServerGetDataTable(query, new System.Data.SqlClient.SqlParameter[1] { new SqlParameter("@id", SqlDbType.Int) { Value = id } });
            dataGridView1.DataSource = dt;

            foreach (DataColumn col in dt.Columns)
            {
                // Hide all columns except "course_name," "absentColumn," and "paidColumn"
                if (col.ColumnName != "course" && col.ColumnName != "absentColumn" && col.ColumnName != "paidColumn")
                {
                    dataGridView1.Columns[col.ColumnName].Visible = false;
                }
            }
            if (courseid !=-1)
              fillsup();
        }
        bool addc = true;
        private void fillsup()
        {
            Gridmoney.DataSource = Base.ServerGetDataTable($"SELECT * FROM payments WHERE enroll_id ='{courseid}'", new SqlParameter[0]);
            string querry = @"SELECT
    sa.id,
    sa.attendance_id,
    a.[date] AS [Date],
    CASE
        WHEN sa.[attended] = 1 THEN 'Present'
        WHEN sa.[attended] = 0 THEN 'Absent'
        ELSE 'recovred'
    END AS [Status]
FROM
    [dbo].[students] s
INNER JOIN
    [dbo].[student_attendance] sa ON s.[id] = sa.[student_id]
INNER JOIN
    [dbo].[attendance] a ON sa.[attendance_id] = a.[id]
INNER JOIN
    [dbo].[courses] c ON a.[course_id] = c.[id]
WHERE
    c.[id] = @courseid -- Replace [SyntheticCourseID] with the actual course ID
    AND
    s.[id] = @id; -- Replace [StudentID] with the actual student ID
";
            SqlParameter[] parameters = new SqlParameter[]
{
                new SqlParameter("@id", SqlDbType.Int) { Value = id },
                new SqlParameter("@courseid", SqlDbType.Int) { Value = courseid },

};
            Gridabsent.DataSource = Base.ServerGetDataTable(querry, parameters);
           if (addc)
            {
                addcol();
                addc = false;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "absentColumn")
            {

                System.Drawing.Image right = Properties.Resources.right;
                System.Drawing.Image __false = Properties.Resources._false;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int totalAbsent = Convert.ToInt32(row.Cells["total_absent"].Value);
                int absent = Convert.ToInt32(row.Cells["absent"].Value);
                // Check if the index cell contains a valid integer value
                if (absent > totalAbsent)
                {
                    e.Value = right;
                }
                else
                {
                    e.Value = __false;
                }


            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "paidColumn")
            {

                System.Drawing.Image right = Properties.Resources.right;
                System.Drawing.Image __false = Properties.Resources._false;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                decimal still = Convert.ToDecimal(row.Cells["still"].Value);
                // Compare still, set the paidColumn image accordingly
                if (still == 0)
                {
                    e.Value = right;
                }
                else
                {
                    e.Value = __false;
                }
            }

        }

        private void btnup_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string querry = @"UPDATE students SET name=@name , phone=@phone , email=@email WHERE id=@id";
                SqlParameter[] parameters = new SqlParameter[]  
                {
                new SqlParameter("@id", SqlDbType.Int) { Value = id },
                new SqlParameter("@name", SqlDbType.NVarChar) { Value = txtname.Text },
                new SqlParameter("@phone", SqlDbType.VarChar) { Value = txtphone.Text },
                new SqlParameter("@email", SqlDbType.VarChar) { Value = txtemail.Text },
                };

                Base.ServerSendDataTable(querry, parameters);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            courseid = (int)row.Cells["id"].Value;
            fillsup();

        }
        public Action cusomclose;
        private void Student_FormClosed(object sender, FormClosedEventArgs e)
        {
            cusomclose.Invoke();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Gridmoney_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            DataGridViewRow row = Gridmoney.Rows[e.RowIndex];
            if (Gridmoney.Columns[e.ColumnIndex].Name == "Delete")
            {
                int id = (int)row.Cells["id"].Value;
                Base.ServerSendDataTable($"DELETE FROM payments WHERE id = '{id}'", new SqlParameter[0]);
                // Remove the row from the DataGridView
                Gridmoney.Rows.Remove(row);
                filllist();
            }
        }

        private void Gridabsent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = Gridabsent.Rows[e.RowIndex];
            if (Gridabsent.Columns[e.ColumnIndex].Name == "Delete" && (string)row.Cells["Status"].Value== "Absent")
            {
                string querry = @"UPDATE student_attendance SET attended = NULL WHERE id=@id";
                int id = (int)row.Cells["id"].Value;
                SqlParameter[] parameter = new SqlParameter[]
                {
               new SqlParameter("@id", SqlDbType.Int) {Value =id  }
                };
                Base.ServerSendDataTable(querry, parameter);
                Gridabsent.Rows.Remove(row);
                filllist();
            }
        }

        private void Gridabsent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Gridabsent.Columns[e.ColumnIndex].Name == "Delete")
            {

                System.Drawing.Image delete = Properties.Resources.delete;
                System.Drawing.Image right = Properties.Resources.right;
                DataGridViewRow row = Gridabsent.Rows[e.RowIndex];
                
                string totalAbsent = String.IsNullOrEmpty( (string)row.Cells["Status"].Value ) ? "Absent": row.Cells["Status"].Value.ToString() ;

                // Check if the index cell contains a valid integer value
                if (totalAbsent == "Absent")
                {
                    e.Value = delete;
                }
                else
                {
                    e.Value = right;
                }


            }
        }
    }
}
