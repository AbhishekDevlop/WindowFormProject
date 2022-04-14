using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Attendence_Project
{
    public partial class SearchForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public SearchForm()
        {
            InitializeComponent();
            con = new SqlConnection(@"Server = DESKTOP-INLRLPK\SQLEXPRESS;DataBase = ProjectDB;Integrated Security = True");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try 
            {
                string qry = "select * from Attendence where EmpId = @Id";
                cmd = new SqlCommand(qry, con);
                con.Open();
                cmd.Parameters.AddWithValue("@Id",Convert.ToInt32(txtSearch.Text));
                dr = cmd.ExecuteReader();

                //DataTable table = new DataTable();
                //table.Load(dr);
                //dataGridView1.DataSource = table;

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(
                            dr["EntryId"].ToString(), dr["EmpId"].ToString(), dr["EmpName"].ToString(),
                            dr["Designation"].ToString(), dr["InTime"].ToString(),
                            dr["OutTime"].ToString(), dr["TotalWorking_Hour"].ToString());
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message);}
            finally { con.Close(); }
        }
    }
}
