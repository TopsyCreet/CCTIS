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
    public partial class CRecords : Form
    {


        private SqlConnection SqlConn;
        private SqlCommand SqlComm;
        private SqlDataReader SqlReader;
        private SqlDataAdapter SqlAda;
        public CRecords()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConn = new SqlConnection("Data Source=.;Initial Catalog=Personal_Assistant;User ID=sa;Password=123456");
                if(crecord.Text.Length!=0)
                {
                    string viewQuery = "SELECT * FROM Complainant WHERE Phone = + '" + crecord.Text + "'";
                    SqlAda = new SqlDataAdapter(viewQuery, SqlConn);
                    DataSet dsSearch = new DataSet();
                    SqlAda.Fill(dsSearch, "Complainant");
                    dataGridView1.DataSource = dsSearch.Tables["Complainant"].DefaultView;
                    button3.Visible = true;
                    button2.Visible = true;
                }
                else
                {
                    MessageBox.Show("The Filled is Empty", "Error Message");
                }
           
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
            try
            {
                //SqlConn = new SqlConnection("Data Source=.;Initial Catalog=Personal_Assistant;User ID=sa;Password=123456");

                string viewQuery = "SELECT * FROM Complainant WHERE Phone = + '" + crecord.Text + "'";
                SqlAda = new SqlDataAdapter(viewQuery, SqlConn);
                DataSet dsSearch = new DataSet();
                SqlAda.Fill(dsSearch, "Complainant");
                dataGridView1.DataSource = dsSearch.Tables["Complainant"].DefaultView;
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
        }

        private void CRecords_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
            panel1.Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
                try
            {
                string viewQuery = "SELECT * FROM Complainant WHERE Phone = +'" + crecord.Text + "'";

                SqlComm = new SqlCommand(viewQuery, SqlConn);
                SqlConn.Open();

                SqlReader = SqlComm.ExecuteReader();
                if (SqlReader.HasRows)
                {
                    SqlReader.Read();
                   /* txtname.Text = SqlReader.GetString(1);
                    txtsex.Text = SqlReader.GetString(2);
                    txtoccu.Text = SqlReader.GetString(3);
                    txtaddress.Text = SqlReader.GetString(4);
                    cmbgender.Text = SqlReader.GetString(5);
                    txtphone.Text = SqlReader.GetString(6);
                    txtusername.Text = SqlReader.GetString(7);
                    */
                    txtname.Text = SqlReader.GetString(1);
                    cmbsex.SelectedItem = SqlReader.GetString(2);
                    txtoccu.Text = SqlReader.GetString(3);
                    cmbeye.SelectedItem = SqlReader.GetString(4);
                    cmbcomplex.SelectedItem = SqlReader.GetString(5);
                    cmbhair.SelectedItem = SqlReader.GetString(6);
                    txtage.Text = SqlReader.GetString(7);
                    rtbaddress.Text = SqlReader.GetString(8);
                    cmbstate.SelectedItem = SqlReader.GetString(9);
                    txtphone.Text = SqlReader.GetString(10);
                    rtbcomplain.Text = SqlReader.GetString(11);
                    dtpreport.Text = SqlReader.GetString(12);
                    dtpRTime.Text = SqlReader.GetString(13);
                    txtoffice.Text = SqlReader.GetString(14);
                    lbluser.Text = SqlReader.GetString(15);


                }
                else
                {
                    MessageBox.Show("Edit Operation Error ", "Phone Number is not found");
                }

                SqlReader.Close();
                SqlConn.Close();

                //==================== Display in Data Grid View ==============
                SqlDataAdapter sqlAda = new SqlDataAdapter(viewQuery, SqlConn);
                DataSet dsContact = new DataSet();
                sqlAda.Fill(dsContact, "Complainant");
                dataGridView1.DataSource = dsContact.Tables["Complainant"].DefaultView;
            }
            catch (Exception sqlex)
            {
                MessageBox.Show(sqlex.Message);
                MessageBox.Show(sqlex.StackTrace);
            }
            panel1.Visible = true;
            btnUpdate.Visible = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                //con = new SqlConnection("Data Source=.;Initial Catalog=PersonalAssistantDatabase;User ID=sa;Password=123456");
                //  string Viewquery = "UPDATE LoginTable SET+"+cmbUpdate.SelectedItem.ToString()+"=+'"+txtUpdate.Text+"'+ WHERE LoginID=+"+UpdatenumericUpDown1.Value+"";
                //  string Viewquery = "UPDATE LoginTable SET " + cmbUpdate.SelectedItem.ToString() + "='" + txtUpdate.Text + "' WHERE LoginID=" + UpdatenumericUpDown1.Value + "";
                string updateQuery = "UPDATE Complainant SET Name='" + txtname.Text + "',Sex='" + cmbsex.Text + "',Occupation='" + txtoccu.Text + "',eyecolor='" + cmbeye.Text + "',Complexion='" + cmbcomplex.Text + "',Haircolor='" + cmbhair.Text + "',Age='" + txtage.Text + "',address='" + rtbaddress.Text + "',State='" + cmbstate.Text +
                    "',Phone='" + txtphone.Text + "',Complain='" + rtbcomplain.Text + "',Report_Date='" + dtpreport.Text + "',Report_Time='" + dtpRTime.Text + "',InCharge='" + txtoffice.Text + "',Username='" + lbluser.Text + "' Where Phone = + '" + crecord.Text + "'";
                // string updateQuery = "Update Contacts Where ContactID = + '" + txtContactID.Text + "' SET Surname='" + txtSurname.Text + "'";
                SqlAda = new SqlDataAdapter(updateQuery, SqlConn);

                DataSet dsUsers = new DataSet();
                SqlAda.Fill(dsUsers, "Complainant");
                // DataGridSeach.DataSource = dsUsers.Tables["User"].DefaultView;
                MessageBox.Show("Update Successful", "Complainant Details");
                panel1.Hide();
                btnUpdate.Hide();

            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
                MessageBox.Show(se.StackTrace);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            var confirmresult = MessageBox.Show("Are You Sure you want to delete This Record ?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmresult == DialogResult.Yes)
            {
                try
                {
                    string Viewquery = "DELETE FROM Complainant WHERE  Phone = + '" + crecord.Text + "'";
                    SqlAda = new SqlDataAdapter(Viewquery, SqlConn);
                    DataSet dsUsers = new DataSet();
                    SqlAda.Fill(dsUsers, "Complainant");
                    //dataGridView1.DataSource = dsUsers.Tables["contact"].DefaultView;
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
            this.Hide();
            this.Show();
        }
    }
}
