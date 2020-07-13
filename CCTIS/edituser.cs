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
    public partial class edituser : Form
    {
        private SqlConnection SqlConn;
        private SqlCommand SqlComm;
        private SqlDataReader SqlReader;
        private SqlDataAdapter SqlAda;
        public edituser()
        {
            InitializeComponent();
        }

        private void edituser_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            try
            {
                string viewQuery = "SELECT * FROM Users WHERE UserID = +'" + txtUserID.Text + "'";

                SqlComm = new SqlCommand(viewQuery, SqlConn);
                SqlConn.Open();

                SqlReader = SqlComm.ExecuteReader();
                if (SqlReader.HasRows)
                {
                    SqlReader.Read();

                    txtuser.Text = SqlReader.GetString(1);
                    txtpass.Text = SqlReader.GetString(2);
                    cmbrole.Text = SqlReader.GetString(3);


                }
                else
                {
                    MessageBox.Show("Edit Operation Error ", "User ID is not found");
                }

                SqlReader.Close();
                SqlConn.Close();

                //==================== Display in Data Grid View ==============
                SqlDataAdapter sqlAda = new SqlDataAdapter(viewQuery, SqlConn);
                DataSet dsSchedule = new DataSet();
                sqlAda.Fill(dsSchedule, "Users");
                dataGridView1.DataSource = dsSchedule.Tables["Users"].DefaultView;
            }
            catch (Exception sqlex)
            {
                MessageBox.Show(sqlex.Message);
                MessageBox.Show(sqlex.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                //con = new SqlConnection("Data Source=.;Initial Catalog=PersonalAssistantDatabase;User ID=sa;Password=123456");
                //  string Viewquery = "UPDATE LoginTable SET+"+cmbUpdate.SelectedItem.ToString()+"=+'"+txtUpdate.Text+"'+ WHERE LoginID=+"+UpdatenumericUpDown1.Value+"";
                //  string Viewquery = "UPDATE LoginTable SET " + cmbUpdate.SelectedItem.ToString() + "='" + txtUpdate.Text + "' WHERE LoginID=" + UpdatenumericUpDown1.Value + "";
                string updateQuery = "UPDATE Users SET Username='" + txtuser.Text + "',Password='" + txtpass.Text + "',Role='" + cmbrole.Text + "' Where UserID = + '" + txtUserID.Text + "'";
                // string updateQuery = "Update Contacts Where ContactID = + '" + txtContactID.Text + "' SET Surname='" + txtSurname.Text + "'";
                SqlAda = new SqlDataAdapter(updateQuery, SqlConn);

                DataSet dsUsers = new DataSet();
                SqlAda.Fill(dsUsers, "Users");
                // DataGridSeach.DataSource = dsUsers.Tables["User"].DefaultView;
                MessageBox.Show("Update Successfully");
                panel1.Hide();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                MessageBox.Show(se.StackTrace);
            }
        }
    }
}
