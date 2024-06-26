﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Sen_s_final_presentation.EMSDataSet1TableAdapters;


namespace Sen_s_final_presentation
{
    public partial class Control_Dashboard : UserControl
    {
        public Control_Dashboard()
        {
            InitializeComponent();
            string EmployeeCount = this.GetCount("EMPLOYEE_FIRST").ToString();
            Tot_emp_label.Text = $"{EmployeeCount}";      
        }
        public int GetCount(string TableName)
        {
            int Count = 0;
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-CPPCSH9\\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True;Encrypt=False");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand($"SELECT Count(*) FROM {TableName}", sqlConnection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Count = Convert.ToInt32(reader.GetValue(0).ToString());
                Tot_emp_label.Text = Count.ToString(); //connected the count to label in dashboard
            }
            sqlConnection.Close();
            return Count;
        }
        public void UpdateEmployee()
        {
            this.Tot_emp_label.Text = GetCount("EMPLOYEE_FIRST").ToString() ; //this will refresh
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            Employees form = new Employees();
            form.Show();
            this.Hide();
        }
    }
}
