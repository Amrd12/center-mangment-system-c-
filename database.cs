using System;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_enrolled
{
    internal class DataBase
    {
        public DataTable ServerGetDataTable(string query, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable(); // local             using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\studentEnroll.mdf"";Integrated Security=True;"))
                                            // online             using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N6QM612;AttachDbFilename=D:\student\studentEnroll.mdf;Persist Security Info=False;User ID=sa;Password=amr12alnbawy;"))

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\studentEnroll.mdf"";Integrated Security=True;"))
            {
                try
                {
                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                  MessageBox.Show("Error executing query: " + ex.Message);
                }
            }
            return dt;
        }
        public void ServerSendDataTable(string query, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\studentEnroll.mdf"";Integrated Security=True;"))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                catch (Exception ex)
                {
                   MessageBox.Show("Error executing query: " + ex.Message);
                }
            }
        }

        public int Servergetid(string query, SqlParameter[] parameters , string name)
        {
            int insertedId = -1; // Initialize to a default value or handle appropriately

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\studentEnroll.mdf"";Integrated Security=True;"))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddRange(parameters);
                        object result = cmd.ExecuteScalar();
                        insertedId = result != null ? (int)result : -1;
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception, e.g., log or display an error message
                     MessageBox.Show("Error executing query: " + ex.Message);
                }
            }

            return insertedId;
        }
        public decimal Servergetdec(string query, SqlParameter[] parameters)
        {
            decimal insertedId = -1; // Initialize to a default value or handle appropriately

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\studentEnroll.mdf"";Integrated Security=True;"))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddRange(parameters);
                            insertedId = (decimal)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception, e.g., log or display an error message
                     MessageBox.Show("Error executing query: " + ex.Message);
                }
            }

            return insertedId;
        }
    }
}


