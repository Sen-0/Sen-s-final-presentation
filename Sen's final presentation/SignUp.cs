﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sen_s_final_presentation
{
    public partial class Form3 : Form
    {
        public Form3()
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
        private void guna2Button1_Click(object sender, EventArgs e) //registration
        {
            try
            {
                if(User_Name.Text!="" && Password_Textbox.Text!="" && Confirm_Password_Textbox.Text!="" && Country_Textbox.Text!="" && BirthDate_picker.Text!=""
                    && Email_Address_Textbox.Text!="" && Address_Textbox.Text!="" && Gender_Picker.Text!="")
                {
                    if (!guna2CustomRadioButton1.Checked) //terms and cond btn check, used ! to invert
                    {
                        a.Text = "Please accept terms and Conditions";
                        a.ForeColor = Color.Red;
                        return;

                    }
                    if (Password_Textbox.Text != Confirm_Password_Textbox.Text)
                    {
                        MessageBox.Show("Password Do Not Match!", "Error");
                        return;
                    }
                    if (MessageBox.Show("Are you sure you want to register?", "Creating an account", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO Login_first VALUES (@User_name,@Password, " +
                            "@Email, @Address, @B_Date, @Gender, @Country )", conn);
                        command.Parameters.AddWithValue("@User_name", User_Name_Textbox.Text);
                        command.Parameters.AddWithValue("@B_Date", BirthDate_picker.Value);
                        command.Parameters.AddWithValue("@Gender", Gender_Picker.Text);
                        command.Parameters.AddWithValue("@Country", Country_Textbox.Text);
                        command.Parameters.AddWithValue("@Address", Address_Textbox.Text);
                        command.Parameters.AddWithValue("@Email", Email_Address_Textbox.Text);
                        command.Parameters.AddWithValue("@Password", Password_Textbox.Text);
                        command.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Registered Successfully!", "Completed");
                        User_Name_Textbox.Text = "";
                        BirthDate_picker.Text = "";
                        Gender_Picker.Text = "";
                        Country_Textbox.Text = "";
                        Address_Textbox.Text = "";
                        Email_Address_Textbox.Text = "";
                        Password_Textbox.Text = "";
                        Confirm_Password_Textbox.Text = "";
                        Login form2 = new Login(); //after confirmed, goes to the login
                        form2.Show();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("fill in the blanks", "Error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CustomRadioButton1.Checked) //this will make sure terms are agreed
            {
                Signup_btn.Enabled = true;
            }
            else
            {
                Signup_btn.Enabled = false;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ&pp=ygUIcmlja3JvbGw%3D"); //terms
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); //exit
        }
    }
}
