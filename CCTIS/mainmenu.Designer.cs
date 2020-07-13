namespace CCTIS
{
    partial class mainmenu
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
            this.lblcheckreminder = new System.Windows.Forms.Label();
            this.txtlabelname1 = new System.Windows.Forms.Label();
            this.quizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editRecordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainmenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crimeCatalogedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complainantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.maleToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.femaleToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblcheckreminder
            // 
            this.lblcheckreminder.AutoSize = true;
            this.lblcheckreminder.BackColor = System.Drawing.Color.Silver;
            this.lblcheckreminder.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckreminder.ForeColor = System.Drawing.Color.Black;
            this.lblcheckreminder.Location = new System.Drawing.Point(1045, 9);
            this.lblcheckreminder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcheckreminder.Name = "lblcheckreminder";
            this.lblcheckreminder.Size = new System.Drawing.Size(84, 21);
            this.lblcheckreminder.TabIndex = 19;
            this.lblcheckreminder.Text = "Welcome :";
            // 
            // txtlabelname1
            // 
            this.txtlabelname1.AutoSize = true;
            this.txtlabelname1.BackColor = System.Drawing.Color.Silver;
            this.txtlabelname1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlabelname1.ForeColor = System.Drawing.Color.Black;
            this.txtlabelname1.Location = new System.Drawing.Point(1154, 8);
            this.txtlabelname1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtlabelname1.Name = "txtlabelname1";
            this.txtlabelname1.Size = new System.Drawing.Size(52, 21);
            this.txtlabelname1.TabIndex = 18;
            this.txtlabelname1.Text = "label1";
            // 
            // quizToolStripMenuItem
            // 
            this.quizToolStripMenuItem.Name = "quizToolStripMenuItem";
            this.quizToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.quizToolStripMenuItem.Text = "Phone";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maleToolStripMenuItem,
            this.femaleToolStripMenuItem,
            this.complainantToolStripMenuItem});
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.calculatorToolStripMenuItem.Text = "Sex";
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.quizToolStripMenuItem});
            this.utilityToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(65, 25);
            this.utilityToolStripMenuItem.Text = "Query";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(233, 26);
            this.deleteToolStripMenuItem1.Text = "Criminal Records";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // addRecordToolStripMenuItem1
            // 
            this.addRecordToolStripMenuItem1.Name = "addRecordToolStripMenuItem1";
            this.addRecordToolStripMenuItem1.Size = new System.Drawing.Size(233, 26);
            this.addRecordToolStripMenuItem1.Text = "Complainant Records";
            this.addRecordToolStripMenuItem1.Click += new System.EventHandler(this.addRecordToolStripMenuItem1_Click);
            // 
            // scheduleDetailsToolStripMenuItem1
            // 
            this.scheduleDetailsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem1,
            this.editRecordToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.scheduleDetailsToolStripMenuItem1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleDetailsToolStripMenuItem1.Name = "scheduleDetailsToolStripMenuItem1";
            this.scheduleDetailsToolStripMenuItem1.Size = new System.Drawing.Size(82, 25);
            this.scheduleDetailsToolStripMenuItem1.Text = "Records";
            // 
            // editRecordToolStripMenuItem1
            // 
            this.editRecordToolStripMenuItem1.Name = "editRecordToolStripMenuItem1";
            this.editRecordToolStripMenuItem1.Size = new System.Drawing.Size(233, 26);
            this.editRecordToolStripMenuItem1.Text = "Suspect Records";
            this.editRecordToolStripMenuItem1.Click += new System.EventHandler(this.editRecordToolStripMenuItem1_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.dToolStripMenuItem.Text = "Delete Record";
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(205, 26);
            this.deleteToolStripMenuItem2.Text = "Crime and Nature";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.deleteToolStripMenuItem.Text = "Criminal List";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editRecordToolStripMenuItem
            // 
            this.editRecordToolStripMenuItem.Name = "editRecordToolStripMenuItem";
            this.editRecordToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.editRecordToolStripMenuItem.Text = "Suspect List";
            this.editRecordToolStripMenuItem.Click += new System.EventHandler(this.editRecordToolStripMenuItem_Click);
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.addRecordToolStripMenuItem.Text = "Complainant List";
            this.addRecordToolStripMenuItem.Click += new System.EventHandler(this.addRecordToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem,
            this.editRecordToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteToolStripMenuItem2,
            this.dToolStripMenuItem});
            this.contactToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.contactToolStripMenuItem.Text = "Reports";
            // 
            // scheduleDetailsToolStripMenuItem
            // 
            this.scheduleDetailsToolStripMenuItem.Name = "scheduleDetailsToolStripMenuItem";
            this.scheduleDetailsToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.scheduleDetailsToolStripMenuItem.Text = "Criminal Registration";
            this.scheduleDetailsToolStripMenuItem.Click += new System.EventHandler(this.scheduleDetailsToolStripMenuItem_Click);
            // 
            // contactDetailsToolStripMenuItem
            // 
            this.contactDetailsToolStripMenuItem.Name = "contactDetailsToolStripMenuItem";
            this.contactDetailsToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.contactDetailsToolStripMenuItem.Text = "Suspect Registration";
            this.contactDetailsToolStripMenuItem.Click += new System.EventHandler(this.contactDetailsToolStripMenuItem_Click);
            // 
            // mainmenuToolStripMenuItem
            // 
            this.mainmenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactDetailsToolStripMenuItem,
            this.scheduleDetailsToolStripMenuItem,
            this.complaintRegistrationToolStripMenuItem,
            this.crimeCatalogedToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.mainmenuToolStripMenuItem.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainmenuToolStripMenuItem.Name = "mainmenuToolStripMenuItem";
            this.mainmenuToolStripMenuItem.Size = new System.Drawing.Size(47, 25);
            this.mainmenuToolStripMenuItem.Text = "File";
            // 
            // complaintRegistrationToolStripMenuItem
            // 
            this.complaintRegistrationToolStripMenuItem.Name = "complaintRegistrationToolStripMenuItem";
            this.complaintRegistrationToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.complaintRegistrationToolStripMenuItem.Text = "Complainant Registration";
            this.complaintRegistrationToolStripMenuItem.Click += new System.EventHandler(this.complaintRegistrationToolStripMenuItem_Click);
            // 
            // crimeCatalogedToolStripMenuItem
            // 
            this.crimeCatalogedToolStripMenuItem.Name = "crimeCatalogedToolStripMenuItem";
            this.crimeCatalogedToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.crimeCatalogedToolStripMenuItem.Text = "Crime Cataloged";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainmenuToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.scheduleDetailsToolStripMenuItem1,
            this.utilityToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1240, 29);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "Welcome User";
            // 
            // maleToolStripMenuItem
            // 
            this.maleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maleToolStripMenuItem1,
            this.femaleToolStripMenuItem1});
            this.maleToolStripMenuItem.Name = "maleToolStripMenuItem";
            this.maleToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.maleToolStripMenuItem.Text = "Suspect";
            // 
            // femaleToolStripMenuItem
            // 
            this.femaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maleToolStripMenuItem2,
            this.femaleToolStripMenuItem2});
            this.femaleToolStripMenuItem.Name = "femaleToolStripMenuItem";
            this.femaleToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.femaleToolStripMenuItem.Text = "Criminal";
            // 
            // complainantToolStripMenuItem
            // 
            this.complainantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maleToolStripMenuItem3,
            this.femaleToolStripMenuItem3});
            this.complainantToolStripMenuItem.Name = "complainantToolStripMenuItem";
            this.complainantToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.complainantToolStripMenuItem.Text = "Complainant";
            this.complainantToolStripMenuItem.Click += new System.EventHandler(this.complainantToolStripMenuItem_Click);
            // 
            // maleToolStripMenuItem1
            // 
            this.maleToolStripMenuItem1.Name = "maleToolStripMenuItem1";
            this.maleToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.maleToolStripMenuItem1.Text = "Male";
            this.maleToolStripMenuItem1.Click += new System.EventHandler(this.maleToolStripMenuItem1_Click);
            // 
            // femaleToolStripMenuItem1
            // 
            this.femaleToolStripMenuItem1.Name = "femaleToolStripMenuItem1";
            this.femaleToolStripMenuItem1.Size = new System.Drawing.Size(152, 26);
            this.femaleToolStripMenuItem1.Text = "Female";
            this.femaleToolStripMenuItem1.Click += new System.EventHandler(this.femaleToolStripMenuItem1_Click);
            // 
            // maleToolStripMenuItem2
            // 
            this.maleToolStripMenuItem2.Name = "maleToolStripMenuItem2";
            this.maleToolStripMenuItem2.Size = new System.Drawing.Size(152, 26);
            this.maleToolStripMenuItem2.Text = "Male";
            this.maleToolStripMenuItem2.Click += new System.EventHandler(this.maleToolStripMenuItem2_Click);
            // 
            // femaleToolStripMenuItem2
            // 
            this.femaleToolStripMenuItem2.Name = "femaleToolStripMenuItem2";
            this.femaleToolStripMenuItem2.Size = new System.Drawing.Size(152, 26);
            this.femaleToolStripMenuItem2.Text = "Female";
            this.femaleToolStripMenuItem2.Click += new System.EventHandler(this.femaleToolStripMenuItem2_Click);
            // 
            // maleToolStripMenuItem3
            // 
            this.maleToolStripMenuItem3.Name = "maleToolStripMenuItem3";
            this.maleToolStripMenuItem3.Size = new System.Drawing.Size(152, 26);
            this.maleToolStripMenuItem3.Text = "Male";
            this.maleToolStripMenuItem3.Click += new System.EventHandler(this.maleToolStripMenuItem3_Click);
            // 
            // femaleToolStripMenuItem3
            // 
            this.femaleToolStripMenuItem3.Name = "femaleToolStripMenuItem3";
            this.femaleToolStripMenuItem3.Size = new System.Drawing.Size(152, 26);
            this.femaleToolStripMenuItem3.Text = "Female";
            this.femaleToolStripMenuItem3.Click += new System.EventHandler(this.femaleToolStripMenuItem3_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 570);
            this.Controls.Add(this.lblcheckreminder);
            this.Controls.Add(this.txtlabelname1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCTIS- MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcheckreminder;
        private System.Windows.Forms.Label txtlabelname1;
        private System.Windows.Forms.ToolStripMenuItem quizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scheduleDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editRecordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainmenuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem complaintRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crimeCatalogedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem femaleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem femaleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem complainantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maleToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem femaleToolStripMenuItem3;
    }
}