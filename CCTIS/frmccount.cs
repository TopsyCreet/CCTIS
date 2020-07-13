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
    public partial class frmccount : Form
    {
        private SqlConnection sqlConn;


        private SqlConnection SqlConn;
        private SqlCommand SqlCom;
        private SqlDataReader SqlReader;
        string role;

        public frmccount()
        {
            InitializeComponent();
        }

        private void frmccount_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConn = new SqlConnection("Data Source=.;Initial Catalog=CCTIS;Integrated Security =True");
                // SqlConn = new SqlConnection("Data Source=.;Initial Catalog=Personal_Assistant;Persist Security Info=True;User ID=sa;Password=123456");
            }
            catch (Exception sqlex)
            {
                MessageBox.Show(sqlex.Message);
                MessageBox.Show(sqlex.StackTrace);
            }
            SqlConn.Close();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
             string str = "SELECT * FROM Users WHERE Username = +'" + txtuser.Text + "'" + " and Password = +'" + txtpass.Text + "' " + "and Role =+ '" + cmbrole.Text + "'";
             SqlCom = new SqlCommand(str, SqlConn);
             try
             {

                 SqlConn.Open();
                  SqlReader = SqlCom.ExecuteReader();
                 if (SqlReader.HasRows)
                 {
                     SqlReader.Read();

                     role = SqlReader.GetString(3);

                     if (role.ToLower() == "admin")
                     {
                         MessageBox.Show("Welcome \t" + txtuser.Text, "Admin_Login");
                         Mainmenu_Admin gn = new Mainmenu_Admin(txtuser.Text);
                         gn.Show();
                         this.Hide();
                     }
                     else if (role.ToLower() == "user")
                     {
                         MessageBox.Show("Welcome \t" + txtuser.Text, "User_Login");
                         mainmenu lk = new mainmenu(txtuser.Text);
                         lk.Show();
                         this.Hide();
                     }
                     else
                     {
                         MessageBox.Show("Invalid Authentication");
                     }
                 }
                 else
                 {
                     MessageBox.Show("Invalid Authentication", "Error Message");
                 }
                 if (txtuser.Text.Length == 0 && txtpass.Text.Length == 0 && cmbrole.Text.Length == 0)
                 {
                     MessageBox.Show("No Filled Can be Left Empty");
                 }
                 else { }
             }
             catch (SqlException se)
             {
                 MessageBox.Show(se.ToString());

             }
             SqlReader.Close();
             SqlConn.Close();

        
             /*
             if (txtuser.Text == "admin" && txtpass.Text =="admin123")
                     {
                         MessageBox.Show("Welcome \t" + txtuser.Text, "Admin_Login");
                         Mainmenu_Admin gn = new Mainmenu_Admin(txtuser.Text);
                         gn.Show();
                         this.Hide();
                     }
                     else if (txtuser.Text == "user" && txtpass.Text=="User123")
                     {
                         MessageBox.Show("Welcome \t" + txtuser.Text, "User_Login");
                         mainmenu lk = new mainmenu(txtuser.Text);
                         lk.Show();
                         this.Hide();
                     }
                     else
                     {
                         MessageBox.Show("Invalid Authentication");
                     }
                 
               
                 if (txtuser.Text.Length == 0 || txtpass.Text.Length == 0 || cmbrole.Text.Length == 0)
                 {
                     MessageBox.Show("No Filled Can be Left Empty");
                 }
                 else { }*/
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkpass1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpass1.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
