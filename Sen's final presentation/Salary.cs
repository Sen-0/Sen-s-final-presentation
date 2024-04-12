using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sen_s_final_presentation
{
    public partial class Salary : UserControl
    {
        public Salary()
        {
            InitializeComponent();
            BindData();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CPPCSH9\\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True;Encrypt=False");
        private void guna2Button1_Click(object sender, EventArgs e) //update s
        {
                try
                {
                    if (Employee_IDbox.Text != "" && Salary_Box.Text != "")
                    {

                        conn.Open();
                        String BaseQuery = "UPDATE EMPLOYEE_FIRST SET  EMP_SALARY = @EMP_SALARY" ;
                        String Condition = $"WHERE EMP_ID=${int.Parse(Employee_IDbox.Text)}";
                        SqlCommand command = new SqlCommand($"{BaseQuery} {Condition}", conn);
                        command.Parameters.AddWithValue("@EMP_ID", int.Parse(Employee_IDbox.Text));
                        command.Parameters.AddWithValue("@EMP_SALARY", int.Parse(Salary_Box.Text));
                        command.ExecuteNonQuery();
                        conn.Close();
                        BindData();
                        MessageBox.Show("Salary Updated Successfully.","Salary Added");
                        Employee_IDbox.Text = "";
                        Salary_Box.Text = "";
                }
                    else
                    {
                        MessageBox.Show("Fill in the blanks.", "Add Value");
                    }
                }
                catch
                {
                    MessageBox.Show("Error","Error");
                }
            
        }
        void BindData()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM EMPLOYEE_FIRST", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            guna2DataGridView1.DataSource = dt;

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if
                (Employee_IDbox.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to Clear record?", "Clear Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    { 
                        conn.Open();
                        string columnName = "EMP_SALARY";
                        string updateQuery = $"UPDATE EMPLOYEE_FIRST SET {columnName} = NULL WHERE EMP_ID = @EMP_ID";
                        SqlCommand command = new SqlCommand(updateQuery, conn);
                        command.Parameters.AddWithValue("@EMP_ID", int.Parse(Employee_IDbox.Text));
                        command.ExecuteNonQuery();
                        conn.Close();
                        BindData();
                        MessageBox.Show("Data successfully deleted!","Data Cleared");

                        Employee_IDbox.Text = "";
                        Salary_Box.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Put Employee ID.","Insert ID");
            }
        }
    }
}
