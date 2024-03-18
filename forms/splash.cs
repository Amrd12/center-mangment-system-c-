using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_enrolled.forms
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
            timer1.Start();
            this.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                int slideSpeed = 2; // Adjust the sliding speed as needed
                panelslide.Left += slideSpeed;

                // If panelslide moves out of the panel1 boundaries, reset its position to the left side of panel1
                if (panelslide.Left > panel1.Right- panelslide.Width)
                {
                    panelslide.Left = panel1.Left - panelslide.Width;
                }

            }
            catch (Exception)
            {
            }
        }
    }
}
