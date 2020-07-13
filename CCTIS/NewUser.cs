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
    public partial class NewUser : Form
    {
        private SqlConnection sqlConn;
        private SqlCommand sqlComma;
        public NewUser()
        {
            InitializeComponent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            string regDate = DateTime.Now.ToShortDateString();

            string insertTicket = "insert into Users(Username,Password,Role) values ('" + txtuser.Text + "','" + txtpass.Text + "','" + cmbrole.Text + "')";

            sqlComma = new SqlCommand(insertTicket, sqlConn);
            try
            {
                sqlConn.Open();
                sqlComma.ExecuteNonQuery();
                sqlComma.Dispose();
                sqlConn.Close();

                MessageBox.Show("New User Added Successfully");
                txtuser.Text = "";
                txtpass.Text = "";
                cmbrole.Text = "";



                //DisplayUsers();
            }
            catch (SqlException sqe)
            {
                MessageBox.Show("Can not open connection ! " + sqe.ToString());
            }
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConn = new SqlConnection("Data Source=.;Initial Catalog=CCTIS;Integrated Security =True");
            }
            catch (Exception sqlex)
            {
                MessageBox.Show(sqlex.Message);
                MessageBox.Show(sqlex.StackTrace);

            }
            sqlConn.Close();
        }
    }
}
