using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCTIS
{
    public partial class CCTIS : Form
    {
        public CCTIS()
        {
            InitializeComponent();
        }

        private void CCTIS_Load(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Red;

         


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Increment(1);
            progressBar1.Show();
            label1.Text = progressBar1.Value.ToString() + "%  completed";



            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                frmccount account = new frmccount();
                account.Show();
                this.Hide();

            }
        }

        private void progressbarIntro_Click(object sender, EventArgs e)
        {
            progressBar1.ForeColor = Color.Red;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
