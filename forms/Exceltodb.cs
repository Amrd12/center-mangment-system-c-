using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace student_enrolled.forms
{
    public partial class Exceltodb : Form
    {
        DataTable Table = new DataTable();
        public string tablename;
        string query;
        SqlParameter[] parameters;
        public Exceltodb()
        {
            InitializeComponent();


        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    
        private void Exceltodb_Load(object sender, EventArgs e)
        {
            maketable();

        }
        private void maketable()
        {

            if (tablename == "courses")
            {
                Table.Columns.Add("name", typeof(string));
                Table.Columns.Add("price", typeof(decimal));
                Table.Columns.Add("day", typeof(DateTime));
            }
            else if (tablename == "stud_enroll")
            {
                Table.Columns.Add("student_id", typeof(int));
                Table.Columns.Add("course_id", typeof(int));
                Table.Columns.Add("paid_price", typeof(decimal));
                Table.Columns.Add("still", typeof(decimal));
                Table.Columns.Add("day", typeof(DateTime));
            }
            else if (tablename == "students")
            {
                Table.Columns.Add("name", typeof(string));
                Table.Columns.Add("phone", typeof(string));
                Table.Columns.Add("email", typeof(string));
                Table.Columns.Add("day", typeof(DateTime));
            }
            this.datatable.DataSource = Table;

        }
        private void btnload_Click(object sender, EventArgs e)
        {
            label1.Text = "ADD:";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "choose an excel file";
            ofd.ShowDialog();
            if (ofd.FileName != null)
                Table = FillDataTableFromExcel(ofd.FileName);
            this.datatable.DataSource = Table;
            datatable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void MakeQurry()
        {
            if (tablename == "courses")
            {
                query = "INSERT INTO courses (name, price ,day) VALUES (@name, @price,@day);";

                parameters = new SqlParameter[]
                {
                new SqlParameter("@name", SqlDbType.NVarChar),
                new SqlParameter("@price", SqlDbType.Decimal),
                new SqlParameter("@day", SqlDbType.DateTime),

                };
            }
            else if (tablename == "stud_enroll")
            {
                query = "INSERT INTO stud_enroll (stud_id, course_id,  paid_price, still , day) VALUES (@student_id, @course_id,  @paid_price, @still , @day);";
                parameters = new SqlParameter[]
               {
                new SqlParameter("@student_id", SqlDbType.Int),
                new SqlParameter("@course_id", SqlDbType.Int),
                new SqlParameter("@paid_price", SqlDbType.Decimal),
                new SqlParameter("@still", SqlDbType.Decimal),
                new SqlParameter("@day", SqlDbType.DateTime),
               };
            }
            else if (tablename == "students")
            {
                query = "INSERT INTO students (name, phone , email,day) VALUES (@name, @phone , @email,@day );";
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@name", SqlDbType.NVarChar),
                    new SqlParameter("@phone", SqlDbType.VarChar),
                    new SqlParameter("@email", SqlDbType.VarChar),
                    new SqlParameter("@day", SqlDbType.DateTime)
                };
               

            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            label1.Text = "start \n";
            int j = 1;

            foreach (DataRow row in Table.Rows)
            {
                MakeQurry();
                for (int i = 0; i < Table.Columns.Count; i++)
                {

                     if (parameters[i].Value != null) parameters[i].Value = null;
                        parameters[i].Value = parvalue(i, row[i].ToString());


                }
                new DataBase().ServerSendDataTable(query, parameters);
                label1.Text += "done " +j +"\n" ; j++;
            }
            MessageBox.Show("done!");
            this.Close();
        }
        private object parvalue(int i, string value)
            {
            if (parameters[i].SqlDbType== SqlDbType.NVarChar)   return value;
            if (parameters[i].SqlDbType == SqlDbType.Int) return int.Parse(value);
            if (parameters[i].SqlDbType == SqlDbType.Decimal) return decimal.Parse(value);
            if (parameters[i].SqlDbType == SqlDbType.DateTime) return DateTime.Parse(value);
            if (parameters[i].SqlDbType == SqlDbType.VarChar) return value;
            if (parameters[i].SqlDbType == SqlDbType.DateTime) return DateTime.Parse(value);
            return null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable FillDataTableFromExcel(string filePath)
        {
            DataTable table = new DataTable();
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties=\"Excel 12.0;HDR=YES;IMEX=1;\"";
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    DataTable schemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    string sheetName = schemaTable.Rows[0]["TABLE_NAME"].ToString();
                    string query = $"SELECT * FROM [{sheetName}]";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            return table;
        }

        private void Exceltodb_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
