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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login form2 = new Login();  //goes to login
            form2.Show();
            this.Hide();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); //goes to Sign Up
            form3.Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); //exit
        }
    }
}
