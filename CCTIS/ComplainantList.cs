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
    public partial class ComplainantList : Form
    {

        private SqlConnection SqlConn;
        private SqlCommand SqlComm;
        private SqlDataReader SqlReader;
        private SqlDataAdapter SqlAda;
        public ComplainantList()
        {
            InitializeComponent();
        }

        private void ComplainantList_Load(object sender, EventArgs e)
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

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConn = new SqlConnection("Data Source=.;Initial Catalog=Personal_Assistant;User ID=sa;Password=123456");

                string viewQuery = "SELECT * FROM Complainant ";
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
            
        }
    
}
