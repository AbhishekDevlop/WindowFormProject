using System;
using System.Data.SqlClient;
using System.Data;

using System.Windows.Forms;

namespace Attendence_Project
{
    public partial class Application : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Application()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server = DESKTOP-INLRLPK\SQLEXPRESS;DataBase = ProjectDB;Integrated Security = True");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into Leave values(@EmpId,@EmpName,@EmpDesignation,@FromDate,@ToDate,@Reason,@status)";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@EmpId", LogIn.EmpId);
                cmd.Parameters.AddWithValue("@EmpName", LogIn.EmpName);
                cmd.Parameters.AddWithValue("@EmpDesignation", LogIn.EmpDesignation);
                cmd.Parameters.AddWithValue("@FromDate", dateTimePickerFrom.Text);
                cmd.Parameters.AddWithValue("@ToDate", dateTimePickerTo.Text);
                cmd.Parameters.AddWithValue("@Reason",txtReason.Text);
                cmd.Parameters.AddWithValue("@status", "Pending");
                int result = cmd.ExecuteNonQuery();
                if(result==1)
                {
                    MessageBox.Show("Leave Applied Successfully");
                }
                else 
                {
                    MessageBox.Show("Failed to apply try again");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
            finally { con.Close(); }


        }
    }
}
