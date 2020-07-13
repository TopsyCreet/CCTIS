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
    public partial class malecri : Form
    {
        private SqlConnection SqlConn;
        private SqlCommand SqlComm;
        private SqlDataReader SqlReader;
        private SqlDataAdapter SqlAda;
        public malecri()
        {
            InitializeComponent();
        }

        private void malecri_Load(object sender, EventArgs e)
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
            try
            {
                string viewQuery = "SELECT * FROM Criminal Where Sex= 'Male'";
                SqlAda = new SqlDataAdapter(viewQuery, SqlConn);
                DataSet dsSearch = new DataSet();
                SqlAda.Fill(dsSearch, "Criminal");
                dataGridView1.DataSource = dsSearch.Tables["Criminal"].DefaultView;
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.ToString());
            }
        }
    }
}
