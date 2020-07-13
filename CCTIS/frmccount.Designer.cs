namespace CCTIS
{
    partial class frmccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkpass1 = new System.Windows.Forms.CheckBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.lberror2 = new System.Windows.Forms.Label();
            this.lberror1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkpass1);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbrole);
            this.panel1.Controls.Add(this.lberror2);
            this.panel1.Controls.Add(this.lberror1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(486, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 402);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // chkpass1
            // 
            this.chkpass1.AutoSize = true;
            this.chkpass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkpass1.Location = new System.Drawing.Point(177, 232);
            this.chkpass1.Name = "chkpass1";
            this.chkpass1.Size = new System.Drawing.Size(136, 22);
            this.chkpass1.TabIndex = 15;
            this.chkpass1.Text = "Show Password";
            this.chkpass1.UseVisualStyleBackColor = true;
            this.chkpass1.CheckedChanged += new System.EventHandler(this.chkpass1_CheckedChanged);
            // 
            // txtpass
            // 
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtpass.Location = new System.Drawing.Point(32, 191);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(281, 26);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // txtuser
            // 
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtuser.Location = new System.Drawing.Point(32, 80);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(281, 30);
            this.txtuser.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Role";
            // 
            // cmbrole
            // 
            this.cmbrole.BackColor = System.Drawing.Color.White;
            this.cmbrole.Font = new System.Drawing.Font("Arial Unicode MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cmbrole.Location = new System.Drawing.Point(32, 319);
            this.cmbrole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(281, 34);
            this.cmbrole.TabIndex = 3;
            // 
            // lberror2
            // 
            this.lberror2.AutoSize = true;
            this.lberror2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberror2.ForeColor = System.Drawing.Color.Red;
            this.lberror2.Location = new System.Drawing.Point(49, 381);
            this.lberror2.Name = "lberror2";
            this.lberror2.Size = new System.Drawing.Size(0, 17);
            this.lberror2.TabIndex = 11;
            // 
            // lberror1
            // 
            this.lberror1.AutoSize = true;
            this.lberror1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lberror1.ForeColor = System.Drawing.Color.Red;
            this.lberror1.Location = new System.Drawing.Point(49, 260);
            this.lberror1.Name = "lberror1";
            this.lberror1.Size = new System.Drawing.Size(0, 17);
            this.lberror1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(486, 628);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(96, 37);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.Transparent;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.Black;
            this.btnnext.Location = new System.Drawing.Point(886, 628);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(96, 37);
            this.btnnext.TabIndex = 7;
            this.btnnext.Text = "Login";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(582, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login To\r\n     CCTIS Application\r\n";
            // 
            // frmccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1247, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnnext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCTIS- Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkpass1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Label lberror2;
        private System.Windows.Forms.Label lberror1;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}