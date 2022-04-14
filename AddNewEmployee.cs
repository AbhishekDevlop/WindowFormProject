using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Attendence_Project
{
    public partial class AddNewEmployee : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public AddNewEmployee()
        {
            InitializeComponent();

            con = new SqlConnection(@"Server = DESKTOP-INLRLPK\SQLEXPRESS;DataBase = ProjectDB;Integrated Security = True");
            try
            {
                string qry = "Select Max(Id) from Employees";
                cmd = new SqlCommand(qry, con);
                con.Open();
                object obj = cmd.ExecuteScalar();
                if (obj == DBNull.Value)
                {
                    txtEmpId.Text = "1";
                }
                else
                {
                    int id = Convert.ToInt32(obj);
                    id++;
                    txtEmpId.Text = id.ToString();
                    txtEmpId.Enabled = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }

        }
         void Clear() 
        { 
            txtEmpId.Clear();
            txtEmpName.Clear();
            txtEmpDesignation.Clear();
            txtEmpAddress.Clear();
            txtEmpSalary.Clear();
            radbtnMale.Checked= false;
            radbtnMale.Checked= false;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into employees values(@EmpId,@EmpName,@EmpDesignation,@EmpSalary,@EmpGender,@EmpAddress)";

                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@EmpId", Convert.ToInt32(txtEmpId.Text));
                cmd.Parameters.AddWithValue("@EmpName", txtEmpName.Text);
                cmd.Parameters.AddWithValue("@EmpDesignation", txtEmpDesignation.Text);
                cmd.Parameters.AddWithValue("@EmpSalary", Convert.ToDouble(txtEmpSalary.Text));
                string gender;
                if (radbtnFemale.Checked == true)
                {
                    gender = "Female";
                }
                else { gender = "Male"; }
                cmd.Parameters.AddWithValue("@EmpGender", gender);

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Successfully save the record");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
