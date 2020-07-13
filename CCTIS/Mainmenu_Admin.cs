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
    public partial class Mainmenu_Admin : Form
    {
        public Mainmenu_Admin(string txtuser)
        {
           
            InitializeComponent();
            txtlabelname1.Text = txtuser;

        }
        private void Mainmenu_Admin_Load(object sender, EventArgs e)
        {

        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewuser rt = new viewuser();
            rt.MdiParent = this;
            rt.Show();
        }

        private void searchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchuser ty = new searchuser();
            ty.MdiParent = this;
           ty.Show();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edituser rr = new edituser();
            rr.MdiParent = this;
            rr.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteuser yy = new deleteuser();
            yy.MdiParent = this;
            yy.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser ty = new NewUser();
            ty.MdiParent = this;
            ty.Show();
        }
    }
}
