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

        Double sal,etfamount, epfamount, gsal, allow, nsal;

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CPPCSH9\\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True;Encrypt=False");
        private void guna2Button1_Click(object sender, EventArgs e) //update salary
        {
                try
                {
                    if (Employee_IDbox.Text != "" && txtnsal.Text != "")
                    {
                      if (MessageBox.Show("Are you sure you want to Update record?", "Update Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
                      {
                        conn.Open();
                        String BaseQuery = "UPDATE EMPLOYEE_FIRST SET  EMP_SALARY = @EMP_SALARY";
                        String Condition = $"WHERE EMP_ID=${int.Parse(Employee_IDbox.Text)}";
                        SqlCommand command = new SqlCommand($"{BaseQuery} {Condition}", conn);
                        command.Parameters.AddWithValue("@EMP_ID", int.Parse(Employee_IDbox.Text));
                        command.Parameters.AddWithValue("@EMP_SALARY", int.Parse(txtnsal.Text));
                        command.ExecuteNonQuery();
                        conn.Close();
                        BindData();
                        MessageBox.Show("Salary Updated Successfully.", "Salary Added");
                        Employee_IDbox.Text = "";
                        txtnsal.Text = "";
                        Salary_Box.Text = "";

                        txtallow.Text = "";
                        txtetf.Text = "";
                        txtepf.Text = "";
                        txtgsal.Text = "";
                      }
                }
                    else
                    {
                        MessageBox.Show("Fill in the blanks.", "Error");
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
        private void guna2Button2_Click(object sender, EventArgs e) //clear salary
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
                        txtnsal.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Insert Employee ID.","Error");
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            sal = Double.Parse(Salary_Box.Text);
            if (Checketf.Checked == true)
                {
                    etfamount = sal * 3 / 100; //etf % in SL is around 3% and this won't be added to the net salary, this will just show the & to the user
                }
            if (Checkepf.Checked == true)
                {
                    epfamount = sal * 8 / 100; // in sl 8% of EPS is deducted from the employee while the employer adds in another 12%
                }
            txtetf.Text = etfamount.ToString();
            txtepf.Text = epfamount.ToString();

            gsal = sal + epfamount; //etf wont be added here, etf amount is just there to showcase

            txtgsal.Text = gsal.ToString();

            if(sal > 250000)  //an allowance that employees get based upon their salaries
            {
                allow = 30000;
            }
            else if (sal > 250000)
            {
                allow = 15000;
            }
            else
            {
                allow = 0;
            }

            txtallow.Text = allow.ToString();

            nsal = gsal + allow; //total salary calculated

            txtnsal.Text = nsal.ToString();  //the amount showed here will be used by the Update button to insert the data into the SQL 
        }
    }
}
