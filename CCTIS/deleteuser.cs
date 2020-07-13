using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CCTIS
{
    public partial class deleteuser : Form
    {
        private SqlConnection SqlConn;
        private SqlCommand SqlComm;
        private SqlDataReader SqlReader;
        private SqlDataAdapter SqlAda;
        public deleteuser()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            btnDelete.Visible = true;
            try
            {
                //SqlConn = new SqlConnection("Data Source=.;Initial Catalog=Personal_Assistant;User ID=sa;Password=123456");

                string viewQuery = "SELECT * FROM Users WHERE UserID = + '" + txtUserID.Text + "'";
                SqlAda = new SqlDataAdapter(viewQuery, SqlConn);
                DataSet dsSearch = new DataSet();
                SqlAda.Fill(dsSearch, "Users");
                dataGridView1.DataSource = dsSearch.Tables["Users"].DefaultView;
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
        }

        private void deleteuser_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConn = new SqlConnection("Data Source=.;Initial Catalog=CCTIS;Integrated Security =True");
            }
            catch (Exception sqlex)
            {
                MessageBox.Show(sqlex.Message);
                MessageBox.Show(sqlex.StackTrace);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmresult = MessageBox.Show("Are You Sure you want to delete This Record ?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmresult == DialogResult.Yes)
            {
                try
                {
                    string Viewquery = "DELETE FROM Users WHERE  UserID = + '" + txtUserID.Text + "'";
                    SqlAda = new SqlDataAdapter(Viewquery, SqlConn);
                    DataSet dsUsers = new DataSet();
                    SqlAda.Fill(dsUsers, "Users");
                    // DataGridSeach.DataSource = dsUsers.Tables["User"].DefaultView;
                    MessageBox.Show("Delete Successfully");
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                    MessageBox.Show(se.StackTrace);
                }
            }
            else
            {

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
