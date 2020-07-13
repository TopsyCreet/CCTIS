using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace CCTIS
{
    public partial class complainant : Form
    {
        private SqlConnection sqlConn;
        private SqlCommand sqlComma;
        private SqlCommand SqlComm;
        private SqlDataReader SqlReader;
        string role;
        public complainant(string txtlabelname1)
        {
            InitializeComponent();
            lbluser.Text = txtlabelname1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void complainant_Load(object sender, EventArgs e)
        {

            try
            {
                sqlConn = new SqlConnection("Data Source=.;Initial Catalog=CCTIS;Integrated Security=True");
            }
            catch (Exception sqlex)
            {
                MessageBox.Show(sqlex.Message);
                MessageBox.Show(sqlex.StackTrace);

            }
            sqlConn.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Length == 0 || cmbsex.Text.Length == 0 || txtoccu.Text.Length == 0 || cmbeye.Text.Length == 0 || cmbcomplex.Text.Length == 0
            || cmbhair.Text.Length == 0 || txtage.Text.Length == 0 || rtbaddress.Text.Length == 0 || cmbstate.Text.Length == 0 || txtphone.Text.Length == 0
            || dtpreport.Text.Length == 0 || dtpRTime.Text.Length == 0
            || txtoffice.Text.Length == 0)
            {
                MessageBox.Show("No Filled can be left empty", "Error Message");
            }
            else
            {


                string regDate = DateTime.Now.ToShortDateString();

                string insertTicket = "insert into Complainant(Name,Sex,Occupation,eyecolor,Complexion,Haircolor,Age,address,State,Phone,Complain,Report_Date,Report_Time,InCharge,Username) values ('" + txtname.Text + "','" + cmbsex.SelectedItem + "','" + txtoccu.Text + "','" + cmbeye.SelectedItem + "','"
                    + cmbcomplex.SelectedItem + "','" + cmbhair.SelectedItem + "','" + txtage.Text + "','" + rtbaddress.Text + "','" + cmbstate.SelectedItem + "','" + txtphone.Text + "','" + rtbcomplain.Text + "','"
                    + dtpreport.Text + "','" + dtpRTime.Text + "','" + txtoffice.Text + "','" + lbluser.Text + "')";

                sqlComma = new SqlCommand(insertTicket, sqlConn);
                try
                {
                    sqlConn.Open();
                    sqlComma.ExecuteNonQuery();
                    sqlComma.Dispose();
                    sqlConn.Close();
                    /* FileStream fs = new FileStream("Complainantdetail.csv", FileMode.Append, FileAccess.Write);
                     StreamWriter w = new StreamWriter(fs);

                     w.WriteLine("Name : {0}\t", txtname.Text);
                     w.WriteLine("Gender :{0}\t", cmbsex.SelectedItem);
                     w.WriteLine("EyeColor :{0}\t", cmbeye.SelectedItem);
                     w.WriteLine("Complexion is:{0}\t", cmbcomplex.SelectedItem);
                     w.WriteLine("HairColor is:{0}\t", cmbhair.SelectedItem);
                     w.WriteLine("Age  is:{0}\t", txtage.Text);
                     w.WriteLine("Address is is:{0}\t", rtbaddress.Text);
                     w.WriteLine("State is:{0}\t", cmbstate.SelectedItem);
                     w.WriteLine("Phone Number is:{0}\t", txtphone.Text);
                     w.WriteLine("Complain is:{0}\t", rtbcomplain.Text);
                     w.WriteLine("Arrest Date is: {0}\t", dtpreport.Text);
                     w.WriteLine("Arrest Time is:{0}\t", dtpRTime.Text);
                     w.WriteLine("Officer in Charge is: {0}\t", txtoffice.Text);
                     w.WriteLine("Username is: {0}", lbluser.Text);


                     w.Flush();
                     w.Close();
                     fs.Close();

                     */

                    txtname.Text = "";
                    cmbsex.SelectedItem = "";
                    txtoccu.Text = "";
                    cmbeye.SelectedItem = "";
                    cmbcomplex.SelectedItem = "";
                    cmbhair.SelectedItem = "";
                    txtage.Text = "";
                    rtbaddress.Text = "";
                    cmbstate.SelectedItem = "";
                    txtphone.Text = "";
                    rtbcomplain.Text = "";
                    dtpreport.Text = "";
                    dtpRTime.Text = "";
                    txtoffice.Text = "";
                    lbluser.Text = "";


                    MessageBox.Show("Complainant Details Saved Successfully", "Complainant Details");

                    //DisplayUsers();
                }
                catch (SqlException sqe)
                {
                    MessageBox.Show("Can not open connection ! ", "Error Message");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
             if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtphone.MaxLength = 11;
            
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtoccu_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtoffice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtage.MaxLength = 3;
            
        }

        private void dtpreport_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
