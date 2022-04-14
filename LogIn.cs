using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Attendence_Project
{
    public partial class LogIn : Form
    {
        public static string EmpId;
        public static string EmpName; 
        public static string EmpDesignation;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public LogIn()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server = DESKTOP-INLRLPK\SQLEXPRESS;DataBase = ProjectDB;Integrated Security = True");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Employees where Id=@Id and password=@password";
                con.Open();
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtUserId.Text));
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EmpDesignation = dr["Designation"].ToString();
                        EmpId = txtUserId.Text;
                        EmpName = dr["Name"].ToString();    


                        if (txtPassword.Text == dr["password"].ToString() && txtUserId.Text == dr["Id"].ToString() && "Admin" == EmpDesignation)
                        {
                            //MessageBox.Show("LogIn");

                            new Admin_MDI().Show();
                            this.Hide();

                        }
                        else
                        {
                            new Employee_MDI().Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }
        }


    }
}
