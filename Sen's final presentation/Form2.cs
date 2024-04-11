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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CPPCSH9\\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True;Encrypt=False");

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
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
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();


                }
                else
                {
                    //this will clear
                    guna2HtmlLabel7.Text = "Wrong user name or password";
                    guna2HtmlLabel7.ForeColor = Color.Red;
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();
                    //to focus
                    guna2TextBox1.Focus();
                }
            }
            catch
            {
                guna2HtmlLabel7.Text = "error";
            }
            finally
            {
                conn.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
                
            
        }
    }
    
}
