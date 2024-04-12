using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sen_s_final_presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Welcome form1 = new Welcome(); //exit
            form1.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.dashboard1.UpdateEmployee(); //shows dashB
            dashboard1.Visible = true;
            employee1.Visible = false;
            salary1.Visible = false;

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false; //shows Emp
            employee1.Visible = true;
            salary1.Visible = false;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false; //Shows Sal
            employee1.Visible = false;
            salary1.Visible = true;
        }
    }
}
