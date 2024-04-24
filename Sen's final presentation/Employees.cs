using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Sen_s_final_presentation
{
    public partial class Employees : UserControl
    {
        public Employees()
        {
            InitializeComponent();
            BindData();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CPPCSH9\\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True;Encrypt=False");
        private void guna2Button1_Click(object sender, EventArgs e)  //insert EMP
        {
            try
            {
                if (Employee_IDbox.Text != "" && Employee_Namebox.Text != "" && Employee_Agebox.Text != "" && Employee_emailBox.Text != "" && Employee_Contactnobox.Text != ""
                    && Employee_addressbox.Text != "" && Employee_genderbox.Text != "" && Employee_JobBox.Text != "") //if the boxes are empty
                {
                    if (MessageBox.Show("Are you sure you want to add new employee?", "Add Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        conn.Open();
                        SqlCommand command = new SqlCommand("INSERT INTO EMPLOYEE_FIRST VALUES (@EMP_ID,@EMP_NAME,@EMP_AGE, " +
                            "@EMP_EMAIL, @EMP_CONTACT, @EMP_ADDRESS, @EMP_GENDER, @EMP_JOB_POSITION, @EMP_SALARY ,@EMP_REVIEW )", conn);
                        command.Parameters.AddWithValue("@EMP_ID", int.Parse(Employee_IDbox.Text));
                        command.Parameters.AddWithValue("@EMP_NAME", Employee_Namebox.Text);
                        command.Parameters.AddWithValue("@EMP_AGE", int.Parse(Employee_Agebox.Text));
                        command.Parameters.AddWithValue("@EMP_EMAIL", Employee_emailBox.Text);
                        command.Parameters.AddWithValue("@EMP_CONTACT", int.Parse(Employee_Contactnobox.Text));
                        command.Parameters.AddWithValue("@EMP_ADDRESS", Employee_addressbox.Text);
                        command.Parameters.AddWithValue("@EMP_GENDER", Employee_genderbox.Text);
                        command.Parameters.AddWithValue("@EMP_JOB_POSITION", Employee_JobBox.Text);
                        command.Parameters.AddWithValue("@EMP_SALARY", 0);
                        command.Parameters.AddWithValue("@EMP_REVIEW", "");
                        command.ExecuteNonQuery();
                        conn.Close();
                        BindData();
                        MessageBox.Show("Data inserted Successfully.", "Successful");
                        Employee_IDbox.Text = "";
                        Employee_Namebox.Text = "";
                        Employee_Agebox.Text = "";
                        Employee_emailBox.Text = "";
                        Employee_Contactnobox.Text = "";
                        Employee_addressbox.Text = "";
                        Employee_genderbox.Text = "";
                        Employee_JobBox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Fill in the blanks.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void BindData() //binding data to the gridview
        {
            SqlCommand command = new SqlCommand("SELECT * FROM EMPLOYEE_FIRST", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }
        private void guna2Button2_Click(object sender, EventArgs e) //update EMP
        {
            if  (Employee_IDbox.Text != "" && Employee_Namebox.Text != "" && Employee_Agebox.Text != "" && Employee_emailBox.Text != "" && Employee_Contactnobox.Text != ""
                    && Employee_addressbox.Text != "" && Employee_genderbox.Text != "" && Employee_JobBox.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to update record?", "Update Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn.Open();
                    String BaseQuery = "UPDATE EMPLOYEE_FIRST SET EMP_NAME = @EMP_NAME, EMP_AGE = @EMP_AGE, EMP_EMAIL =  @EMP_EMAIL, EMP_CONTACT = @EMP_CONTACT, EMP_ADDRESS = @EMP_ADDRESS, EMP_GENDER = @EMP_GENDER, EMP_JOB_POSITION = @EMP_JOB_POSITION";
                    String Condition = $"WHERE EMP_ID=${int.Parse(Employee_IDbox.Text)}";
                    SqlCommand command = new SqlCommand($"{BaseQuery} {Condition}", conn);
                    command.Parameters.AddWithValue("@EMP_NAME", Employee_Namebox.Text);
                    command.Parameters.AddWithValue("@EMP_AGE", int.Parse(Employee_Agebox.Text));
                    command.Parameters.AddWithValue("@EMP_EMAIL", Employee_emailBox.Text);
                    command.Parameters.AddWithValue("@EMP_CONTACT", int.Parse(Employee_Contactnobox.Text));
                    command.Parameters.AddWithValue("@EMP_ADDRESS", Employee_addressbox.Text);
                    command.Parameters.AddWithValue("@EMP_GENDER", Employee_genderbox.Text);
                    command.Parameters.AddWithValue("@EMP_JOB_POSITION", Employee_JobBox.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                    BindData();
                    MessageBox.Show("Data Updated Successfully.", "Successful");
                    Employee_IDbox.Text = "";
                    Employee_Namebox.Text = "";
                    Employee_Agebox.Text = "";
                    Employee_emailBox.Text = "";
                    Employee_Contactnobox.Text = "";
                    Employee_addressbox.Text = "";
                    Employee_genderbox.Text = null;
                    Employee_JobBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fill in the blanks.","Error");
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)  //delete EMP
        {
            if
                (Employee_IDbox.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to delete record?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Delete EMPLOYEE_FIRST WHERE EMP_ID = '" + int.Parse(Employee_IDbox.Text) + "'", conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Data successfully deleted!","Successful");
                    BindData();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Insert Employee ID.","Error");
            }
        }
    }
}
