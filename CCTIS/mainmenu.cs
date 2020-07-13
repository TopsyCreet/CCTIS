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
    public partial class mainmenu : Form
    {

        private SqlConnection SqlConn;
        private SqlCommand SqlComm;
        private SqlDataReader SqlReader;
        string role;
        public mainmenu(string txtuser)
        {

            InitializeComponent();
            txtlabelname1.Text = txtuser;

        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
           
        }

        private void complaintRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            complainant pla = new complainant(txtlabelname1.Text);
            pla.MdiParent = this;
            pla.Show();
        }

        private void contactDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suspect sus = new Suspect(txtlabelname1.Text);
            sus.MdiParent = this;
            sus.Show();
        }

        private void scheduleDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Criminal cri = new Criminal(txtlabelname1.Text);
            cri.MdiParent = this;
            cri.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmccount cc = new frmccount();
            cc.Show();
            this.Hide();
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplainantList le = new ComplainantList();
            le.MdiParent = this;
            le.Show();

        }

        private void editRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Suspect_List ut = new Suspect_List();
            ut.MdiParent = this;
            ut.Show();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriminalList tu = new CriminalList();
            tu.MdiParent = this;
            tu.Show();
        }

        private void addRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CRecords ie = new CRecords();
            ie.MdiParent = this;
            ie.Show();
        
        }

        private void editRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SRecord ty = new SRecord();
            ty.MdiParent = this;
            ty.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            crRecord tr = new crRecord();
            tr.MdiParent = this;
            tr.Show();
        }

        private void maleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            malesus ui = new malesus();
            ui.MdiParent = this;
            ui.Show();

        }

        private void femaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            femalesus un = new femalesus();
            un.MdiParent = this;
            un.Show();

        }

        private void maleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            malecri r = new malecri();
            r.MdiParent = this;
            r.Show();
        }

        private void femaleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            femalecri t = new femalecri();
            t.MdiParent = this;
            t.Show();
        }

        private void maleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            malecomp jh = new malecomp();
            jh.MdiParent = this;
            jh.Show();
        }

        private void complainantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void femaleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            femalecomp p = new femalecomp();
            p.MdiParent = this;
            p.Show();
        }
    }
}
