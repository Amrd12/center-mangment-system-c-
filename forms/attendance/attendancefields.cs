using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_enrolled.forms.attendance
{

    public partial class attendancefields : Form
    {
        private List<Studentattend> studentattented = new List<Studentattend>();
        private List<Studentattend> studentabsent = new List<Studentattend>();
        private List<Studentattend> studentbanned = new List<Studentattend>();

        private int courseId;
        private DataBase Base = new DataBase();
        private int attendance_id;
       private QR qR = new QR();

        public attendancefields(int courseid, int attend_id)
        {
            this.courseId = courseid;
            this.attendance_id = attend_id;
            InitializeComponent();
            Dictionary<string, List<Studentattend>> studentListALL = new Studentattend().GetAttendAndAbsendStudents( attendance_id);
            studentattented = studentListALL["attended"].OrderBy(student => student.ID).ToList();
            studentabsent = studentListALL["absent"].OrderBy(student => student.ID).ToList();
            studentbanned = studentListALL["banned"].OrderBy(student => student.ID).ToList();
            setup();
            fill_ablist(studentattented , studentabsent);
            qR.QRCodeScanned += HandleQRCodeScanned;
        }
        private void fill_ablist(List<Studentattend> statt , List<Studentattend> stab)
        {

            ablist.Items.Clear();
            attlist.Items.Clear();
            // Iterate through the studentList and add each student's information to the ListBox
            foreach (Studentattend student in statt)
            {
                // Create a formatted string with the student's information
                string studentInfo = $"{student.ID} : {student.Name} - Paid: {student.Paid}, Still: {student.Still} , total absent : {student.absent}";

                // Add the formatted string to the ListBox
                attlist.Items.Add(studentInfo);
            }
            foreach (Studentattend student in stab)
            {
                // Create a formatted string with the student's information
                string studentInfo = $"{student.ID} : {student.Name} - Paid: {student.Paid}, Still: {student.Still}, total absent : {student.absent}";

                // Add the formatted string to the ListBox
                ablist.Items.Add(studentInfo);
            }
        }

        private void setup()
        {
            txtcourse.Text += Base.ServerGetDataTable($"SELECT name FROM courses WHERE id = '{courseId}' ", new System.Data.SqlClient.SqlParameter[0]).Rows[0][0].ToString();
            txtdate.Text += Base.ServerGetDataTable($"SELECT date FROM attendance WHERE id = '{attendance_id}' ", new System.Data.SqlClient.SqlParameter[0]).Rows[0][0].ToString();
            btntotal.Text += studentabsent.Count() + studentattented.Count();
            btnab.Text +=   studentabsent.Count();
            btnatt.Text += studentattented.Count();
            foreach (Studentattend student in studentbanned)
            {
                // Create a formatted string with the student's information
                string studentInfo = $"{student.ID} : {student.Name} - Paid: {student.Paid}, Still: {student.Still}, total absent : {student.absent}";

                // Add the formatted string to the ListBox
                bannedlist.Items.Add(studentInfo);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            if (attlist.SelectedIndex >= 0) MessageBox.Show("attend");
            else if (ablist.SelectedIndex >= 0) MessageBox.Show("absent");
            else MessageBox.Show("Please select one from any of listes");

        }

        private void ablist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ablist.SelectedIndex == -1) return;
            // Get the selected student from the absent list
            Studentattend selectedStudent = studentabsent[ablist.SelectedIndex];
            selectedStudent.Attended = true;

            // Remove the student from the absent list  
            studentabsent.RemoveAt(ablist.SelectedIndex);

            // Add the student to the attended list
            studentattented.Add(selectedStudent);
            studentattented = studentattented.ToList();
            studentabsent = studentabsent.ToList();
            btnab.Text = btnab.Text.Substring(0,11) + (int.Parse(btnab.Text.Substring(11)) -1).ToString();
            btnatt.Text = btnatt.Text.Substring(0, 12) + (int.Parse(btnatt.Text.Substring(12)) + 1).ToString();

            // Refresh the ListBox
            fill_ablist(studentattented , studentabsent);

            //MessageBox.Show("Changed to attend");


        }

        private void attlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attlist.SelectedIndex == -1) return;

            // Get the selected student from the attended list
            Studentattend selectedStudent = studentattented[attlist.SelectedIndex];
            selectedStudent.Attended = false;
            // Remove the student from the attended list
            studentattented.RemoveAt(attlist.SelectedIndex);

            // Add the student to the absent list
            studentabsent.Add(selectedStudent);
            studentattented = studentattented.OrderBy(student => student.ID).ToList();
            studentabsent = studentabsent.OrderBy(student => student.ID).ToList();
            btnab.Text = btnab.Text.Substring(0, 11) + (int.Parse(btnab.Text.Substring(11)) + 1).ToString();
            btnatt.Text = btnatt.Text.Substring(0, 12) + (int.Parse(btnatt.Text.Substring(12)) - 1).ToString();
            // Refresh the ListBox
            fill_ablist(studentattented, studentabsent);


        }

        private void snum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    snumsearch(int.Parse(snum.Text));
                    snum.Text = "";
                }
                catch (Exception ex) { MessageBox.Show("please enter a umber"); }
            }
        }
        private void snumsearch(int studentId)
        {
            Studentattend attendedStudent = studentattented.FirstOrDefault(student => student.ID == studentId);

            // Find the student in the absent list
            Studentattend absentStudent = studentabsent.FirstOrDefault(student => student.ID == studentId);

            if (attendedStudent != null)
            {
                // Remove the student from the attended list
                studentattented.Remove(attendedStudent);
                attendedStudent.Attended = true;
                // Add the student to the absent list
                studentabsent.Add(attendedStudent);

                // Refresh the ListBox
                studentattented = studentattented.ToList();
                studentabsent = studentabsent.ToList();
                // Refresh the ListBox
                fill_ablist(studentattented, studentabsent);

                btnab.Text = btnab.Text.Substring(0, 11) + (int.Parse(btnab.Text.Substring(11)) + 1).ToString();
                btnatt.Text = btnatt.Text.Substring(0, 12) + (int.Parse(btnatt.Text.Substring(12)) - 1).ToString();
            }
            else if (absentStudent != null)
            {
                // Remove the student from the absent list
                studentabsent.Remove(absentStudent);
                absentStudent.Attended= false;
                // Add the student to the attended list
                studentattented.Add(absentStudent);

                // Refresh the ListBox
                studentattented = studentattented.ToList();
                studentabsent = studentabsent.ToList();
                // Refresh the ListBox
                fill_ablist(studentattented, studentabsent);
                btnab.Text = btnab.Text.Substring(0, 11) + (int.Parse(btnab.Text.Substring(11)) - 1).ToString();
                btnatt.Text = btnatt.Text.Substring(0, 12) + (int.Parse(btnatt.Text.Substring(12)) + 1).ToString();
            }
            else
            {
                MessageBox.Show("Student ID not found in either list");
            }
        }

        private void sname_TextChanged(object sender, EventArgs e)
        {
            string searchText = sname.Text;
            if (searchText != "")
            {
                // Filter the studentattented list based on the search string (searching in student names)
                var filteredAttendedList = studentattented.Where(student => student.Name.ToLower().Contains(searchText.ToLower())).OrderBy(student => student.ID).ToList();

                // Filter the studentabsent list based on the search string (searching in student names)
                var filteredAbsentList = studentabsent.Where(student => student.Name.ToLower().Contains(searchText.ToLower())).OrderBy(student => student.ID).ToList();


                fill_ablist(filteredAttendedList, filteredAbsentList);
            }
            else
            {
                studentattented = studentattented.OrderBy(student => student.ID).ToList();
                studentabsent = studentabsent.OrderBy(student => student.ID).ToList();
                // Refresh the ListBox
                fill_ablist(studentattented, studentabsent);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            foreach (Studentattend st in studentabsent)
            {
                new Studentattend().student_save(st, attendance_id);
            }
            foreach (Studentattend st in studentattented)
            {
                new Studentattend().student_save(st, attendance_id);
            }
            string querry = $"UPDATE attendance SET attended='{studentattented.Count.ToString()}' , absent='{studentabsent.Count.ToString()}' where " +
                $"id = '{attendance_id.ToString()}'";
            new DataBase().ServerSendDataTable(querry, new SqlParameter[0]);
            close.PerformClick();    
        }
        bool activecam = true;
        private void btnCamQR_Click(object sender, EventArgs e)
        {
            if (activecam == true) {
                MessageBox.Show("start camera");
                 qR.StartScanning();
                activecam = false;


            }
            else
            {
                MessageBox.Show("end camera");
                activecam = true;
                qR.StopScanning();
            }
        }
        private void HandleQRCodeScanned(string scannedData)
        {
            int studentId = Convert.ToInt32(scannedData);
            // Process the scanned QR code data here
            //   Student attendedStudent = studentattented.FirstOrDefault(student => student.ID == studentId);

            // Find the student in the absent list
            Studentattend absentStudent = studentabsent.FirstOrDefault(student => student.ID == studentId);


             if (absentStudent != null)
            {
                // Remove the student from the absent list
                studentabsent.Remove(absentStudent);
                absentStudent.Attended = false;
                // Add the student to the attended list
                studentattented.Add(absentStudent);

                // Refresh the ListBox
                studentattented = studentattented.OrderBy(student => student.ID).ToList();
                studentabsent = studentabsent.OrderBy(student => student.ID).ToList();
                // Refresh the ListBox
                fill_ablist(studentattented, studentabsent);
                btnab.Text = btnab.Text.Substring(0, 11) + (int.Parse(btnab.Text.Substring(11)) - 1).ToString();
                btnatt.Text = btnatt.Text.Substring(0, 12) + (int.Parse(btnatt.Text.Substring(12)) + 1).ToString();
            }
            else
            {
               // MessageBox.Show("Student ID not found in either list");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }


        public Action customclose  ;
        private void attendancefields_FormClosed(object sender, FormClosedEventArgs e)
        {
            customclose.Invoke();
        }

        private void bannedlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bannedlist.SelectedIndex == -1) return;
            // Get the selected student from the absent list
             selectedStudent = studentbanned[bannedlist.SelectedIndex];
            openChildFormInPanel(selectedStudent.ID);
        }
        Studentattend selectedStudent;
        private void openChildFormInPanel(int id)
        {
            course field = new course(id);
            field.cusomclose += customclosein;
            this.panel3.Visible = false;
            field.TopLevel = false;
            field.FormBorderStyle = FormBorderStyle.None;
            field.Dock = DockStyle.Fill;
            this.Controls.Add(field);
            field.BringToFront();
            field.Show();
            field.Focus();
        }

        private void customclosein()
        {
            this.panel3.Visible = true;
            Studentattend st = new Studentattend().student(courseId,selectedStudent.ID,attendance_id);
            if (st != null)
            {
                studentbanned.Remove(selectedStudent);
                if(st.Attended) {
                    studentattented.Add(st);
                }
                else {
                    studentabsent.Add(st);
                }
                fill_ablist(studentattented, studentabsent);
                bannedlist.Items.Clear();
                foreach (Studentattend student in studentbanned)
                {
                    // Create a formatted string with the student's information
                    string studentInfo = $"{student.ID} : {student.Name} - Paid: {student.Paid}, Still: {student.Still}, total absent : {student.absent}";

                    // Add the formatted string to the ListBox
                    bannedlist.Items.Add(studentInfo);
                }
                // Create a formatted string with the student's information

                btnab.Text = btnab.Text.Substring(0, 11) +studentabsent.Count().ToString();
                btnatt.Text = btnatt.Text.Substring(0, 12) +  studentattented.Count().ToString();
            }

        }
    }
}
