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
    public partial class EmployeeReview : UserControl
    {
        public EmployeeReview()
        {
            InitializeComponent();
            BindData();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CPPCSH9\\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True;Encrypt=False");
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReviewBox.Text != "" && ReviewEMPIDbox.Text != "")
                {
                    conn.Open();
                    String BaseQuery = "UPDATE EMPLOYEE_FIRST SET EMP_REVIEW = @EMP_REVIEW";
                    String Condition = $"WHERE EMP_ID={ReviewEMPIDbox.Text}";
                    SqlCommand command = new SqlCommand($"{BaseQuery} {Condition}", conn);
                    command.Parameters.AddWithValue("@EMP_ID", int.Parse(ReviewEMPIDbox.Text));
                    command.Parameters.AddWithValue("@EMP_REVIEW", ReviewBox.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                    BindData();
                    MessageBox.Show("Review Updated Successfully.", "Review Added");
                    ReviewBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Fill in the blanks.", "Add Value");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Error");
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
                (ReviewEMPIDbox.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to Clear Review?", "Clear Review", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    {
                        conn.Open();
                        string columnName = "EMP_REVIEW";
                        string updateQuery = $"UPDATE EMPLOYEE_FIRST SET {columnName} = NULL WHERE EMP_ID = @EMP_ID";
                        SqlCommand command = new SqlCommand(updateQuery, conn);
                        command.Parameters.AddWithValue("@EMP_ID", int.Parse(ReviewEMPIDbox.Text));
                        command.ExecuteNonQuery();
                        conn.Close();
                        BindData();
                        MessageBox.Show("Data successfully deleted!", "Data Cleared");

                        ReviewEMPIDbox.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Put Employee ID.", "Insert ID");
            }
        }
    }
}
