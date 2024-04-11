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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();


        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Employee.UpdateEmployee();
            dashboard1.Visible = true;
            employee1.Visible = false;

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            employee1.Visible = true;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
