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
using System.Text.RegularExpressions;


namespace CCTIS
{
    public partial class Criminal : Form
    {
        Image File;

        private SqlConnection sqlConn;
        private SqlCommand sqlComma;

   
        private SqlCommand SqlComm;
        private SqlDataReader SqlReader;
        string role;
        public Criminal(string  txtlabelname1)
        {
            InitializeComponent();
        lbluser.Text= txtlabelname1;
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void Criminal_Load(object sender, EventArgs e)
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

            if (txtname.Text.Length == 0 || cmbgender.Text.Length == 0 || txtoccu.Text.Length == 0 || cmbeye.Text.Length == 0 || cmbcomplex.Text.Length == 0
                || cmbhair.Text.Length == 0 || txtage.Text.Length == 0 || rtbaddress.Text.Length == 0 || cmbstate.Text.Length == 0 || txtphone.Text.Length == 0
                || nheight.Text.Length == 0 || txtnational.Text.Length == 0 || nweight.Text.Length == 0 || dtpArrest.Text.Length == 0 || dtpRTime.Text.Length == 0
                || txtoffice.Text.Length == 0 || cmbcaseType.Text.Length == 0 || dtpconvict.Text.Length == 0 || txtcode.Text.Length == 0 || txtcellno.Text.Length == 0
                || cmbcourt.Text.Length == 0 || txtverdict.Text.Length == 0)
            {
                MessageBox.Show("No Filled can be left empty", "Error Message");
            }
            else
            {
                string regDate = DateTime.Now.ToShortDateString();

                string insertTicket = "insert into Criminal(Name,Sex,Occupation,eyecolor,Complexion,Haircolor,Age,address,State,Phone,Height,National_Id,Weight,Arrest_Date,Arrest_Time,INCharge,Case_Type,ConvictDate,CrimeCode,Cell_No,Court_Type,Verdict,Username) values ('" + txtname.Text + "','" + cmbgender.SelectedItem + "','" + txtoccu.Text + "','" + cmbeye.SelectedItem + "','"
                    + cmbcomplex.SelectedItem + "','" + cmbhair.SelectedItem + "','" + txtage.Text + "','" + rtbaddress.Text + "','" + cmbstate.SelectedItem + "','" + txtphone.Text + "','" + nheight.Text + "','" + txtnational.Text + "','" + nweight.Text + "','"
                    + dtpArrest.Text + "','" + dtpRTime.Text + "','" + txtoffice.Text + "','" + cmbcaseType.Text + "','" + dtpconvict.Text + "','" + txtcode.Text + "','" + txtcellno.Text + "','" + cmbcourt.SelectedItem + "','" + txtverdict.Text + "','" + lbluser.Text + "')";

                sqlComma = new SqlCommand(insertTicket, sqlConn);
                try
                {
                    sqlConn.Open();
                    sqlComma.ExecuteNonQuery();
                    sqlComma.Dispose();
                    sqlConn.Close();
                    /*
                       FileStream fs = new FileStream("Criminaldetails.csv", FileMode.Append, FileAccess.Write);
                                    StreamWriter w = new StreamWriter(fs);

                                    w.WriteLine("Name is: {0}", txtname.Text);
                                    w.WriteLine("Gender is:{0}", cmbgender.SelectedItem);
                                    w.WriteLine("EyeColor is:{0}", cmbeye.SelectedItem);
                                    w.WriteLine("Complexion is:{0}", cmbcomplex.SelectedItem);
                                    w.WriteLine("HairColor is:{0}", cmbhair.SelectedItem);
                                    w.WriteLine("Age  is:{0}", txtage.Text);
                                    w.WriteLine("Address is is:{0}", rtbaddress.Text);
                                    w.WriteLine("State is:{0}", cmbstate.SelectedItem);
                                    w.WriteLine("Phone Number is:{0}", txtphone.Text);
                                    w.WriteLine("Height is:{0}", nheight.Text);
                                    w.WriteLine("National Id is:{0}", txtnational.Text);
                                    w.WriteLine("Weight is:{0}", nweight.Text);
                                    w.WriteLine("Arrest Date is: {0}", dtpreport.Text);
                                    w.WriteLine("Arrest Time is:{0}\n\n\n", dtpRTime.Text);
                                    w.WriteLine("Officer in Charge is: {0}", txtoffice.Text);
                                    w.WriteLine("Charged Type is: {0}", cmbcaseType.SelectedItem);
                                    w.WriteLine("Conviction Date is: {0}", dtpconvict.Text);
                                    w.WriteLine("ChargedCode is: {0}", txtcode.Text);
                                    w.WriteLine("Cell number is: {0}", txtcellno.Text);
                                    w.WriteLine("court Type is: {0}", cmbcourt.SelectedItem);
                                    w.WriteLine("Verdict is: {0}", txtverdict.Text);
                                    w.WriteLine("Username is: {0}", lbluser.Text);


                                    w.Flush();
                                    w.Close();
                                    fs.Close();*/

                    txtname.Text = "";
                    cmbgender.SelectedItem = "";
                    txtoccu.Text = "";
                    cmbeye.SelectedItem = "";
                    cmbcomplex.SelectedItem = "";
                    cmbhair.SelectedItem = "";
                    txtage.Text = "";
                    rtbaddress.Text = "";
                    cmbstate.SelectedItem = "";
                    txtphone.Text = "";
                    nheight.Text = "";
                    txtnational.Text = "";
                    nweight.Text = "";
                    dtpArrest.Text = "";
                    dtpRTime.Text = "";
                    txtoffice.Text = "";
                    cmbcaseType.SelectedItem = "";
                    dtpconvict.Text = "";
                    txtcode.Text = "";
                    txtcellno.Text = "";
                    cmbcourt.SelectedItem = "";
                    txtverdict.Text = "";
                    lbluser.Text = "";

                   

                    MessageBox.Show("Criminal Details Saved Successfully", "Criminal Details");

                    //DisplayUsers();
                }
                catch (SqlException sqe)
                {
                    MessageBox.Show("Can not open connection ! ", "Error Message");
                }
            }

        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtoccu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtoffice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtcode.MaxLength = 5;
            
        }

        private void txtcellno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtcellno.MaxLength = 3;
            
        }

        private void txtnational_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtnational.MaxLength =8;
            
        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtage.MaxLength = 3;
            
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            txtphone.MaxLength = 11;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png All Files(*.*)|*.|";

                if (f.ShowDialog() == DialogResult.OK)
                {
                    File = Image.FromFile(f.FileName);
                    ptb1.Image = File;
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SaveFileDialog g = new SaveFileDialog();
            g.Filter = "JPG(*JPG)|*.jpg";
            if (g.ShowDialog() == DialogResult.OK)
            {
                File.Save(g.FileName);
            }
        }

        private void cmbhair_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
