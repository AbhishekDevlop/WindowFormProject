using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Timers;

namespace Attendence_Project
{
    public partial class Admin_MDI : Form
    {
        SqlConnection con;
        SqlCommand cmd;
       SqlDataReader dr;

        // DateTime start;
        DateTime start = DateTime.Now;
        public Admin_MDI()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server = DESKTOP-INLRLPK\SQLEXPRESS;DataBase = ProjectDB;Integrated Security = True");
            try
            {
            
                 string intime = start.ToString();
                string qry = "insert into Attendence (EmpId,EmpName,Designation,InTime)values(@EmpId,@EmpName,@EmpDesignation,@InTime)";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@EmpId", LogIn.EmpId);
                cmd.Parameters.AddWithValue("@EmpName",LogIn.EmpName);
                cmd.Parameters.AddWithValue("@EmpDesignation", LogIn.EmpDesignation);
                cmd.Parameters.AddWithValue("@InTime",intime);
                
                cmd.ExecuteNonQuery();
                labName.Text = "Welcome "+LogIn.EmpName;
             }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }
        }

        private void ToolStripMenuItemAddNewEmployee_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemSearchEmployeeDetails_Click(object sender, EventArgs e)
        {
            SearchForm sf = new SearchForm();
            sf.MdiParent = this;
            sf.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
         
            try
            {
                cmd = new SqlCommand("sp_Attendence_LastEntry", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                DateTime end = DateTime.Now;
                string outTime = end.ToString();
                cmd.Parameters.AddWithValue("@OutTime", outTime);
                TimeSpan workingHour = start - end;
                string workHour =(workingHour.Hours).ToString();
                cmd.Parameters.AddWithValue("@TotalWorking_Hour", workHour);
                cmd.Parameters.AddWithValue("@EmpId", LogIn.EmpId);
                int result = cmd.ExecuteNonQuery();
                if(result == 1) 
                {
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("NotDone");
                }

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            finally { con.Close(); }
        }
    }
}
