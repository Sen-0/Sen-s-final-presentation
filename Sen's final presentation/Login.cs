using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace Sen_s_final_presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CPPCSH9\\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True;Encrypt=False");

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Welcome form1 = new Welcome(); //exit
            form1.Show();
            this.Hide();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //login 
            string username = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;
            try
            {
                string querry = "SELECT * FROM Login_first WHERE User_name = '" + guna2TextBox1.Text + "' AND Password = '" + guna2TextBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    username = guna2TextBox1.Text;
                    password = guna2TextBox2.Text;
                    //page that loads next
                    MainForm form4 = new MainForm();
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    //this will clear out the text boxes
                    MessageBox.Show("Wrong Username or Password.", "Try again");
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();
                    //to focus
                    guna2TextBox1.Focus();
                }
            }
            catch
            {
                guna2HtmlLabel7.Text = "Error";
                guna2HtmlLabel7.ForeColor = Color.Red;
            }
            finally
            {
                conn.Close();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
