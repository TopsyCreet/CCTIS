namespace CCTIS
{
    partial class complainant
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtoffice = new System.Windows.Forms.TextBox();
            this.dtpRTime = new System.Windows.Forms.DateTimePicker();
            this.dtpreport = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbcomplain = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtoccu = new System.Windows.Forms.TextBox();
            this.cmbstate = new System.Windows.Forms.ComboBox();
            this.cmbcomplex = new System.Windows.Forms.ComboBox();
            this.cmbeye = new System.Windows.Forms.ComboBox();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.rtbaddress = new System.Windows.Forms.RichTextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.cmbhair = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 450);
            this.panel1.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(772, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 32);
            this.button3.TabIndex = 46;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(618, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 45;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(461, 408);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(98, 35);
            this.btnsave.TabIndex = 44;
            this.btnsave.Text = "Submit";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtoffice);
            this.groupBox2.Controls.Add(this.dtpRTime);
            this.groupBox2.Controls.Add(this.dtpreport);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(461, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 350);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Station Details";
            // 
            // txtoffice
            // 
            this.txtoffice.Location = new System.Drawing.Point(157, 214);
            this.txtoffice.Name = "txtoffice";
            this.txtoffice.Size = new System.Drawing.Size(239, 24);
            this.txtoffice.TabIndex = 43;
            this.txtoffice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoffice_KeyPress);
            // 
            // dtpRTime
            // 
            this.dtpRTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpRTime.Location = new System.Drawing.Point(189, 123);
            this.dtpRTime.Name = "dtpRTime";
            this.dtpRTime.Size = new System.Drawing.Size(207, 24);
            this.dtpRTime.TabIndex = 31;
            // 
            // dtpreport
            // 
            this.dtpreport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpreport.Location = new System.Drawing.Point(189, 27);
            this.dtpreport.Name = "dtpreport";
            this.dtpreport.Size = new System.Drawing.Size(207, 24);
            this.dtpreport.TabIndex = 30;
            this.dtpreport.ValueChanged += new System.EventHandler(this.dtpreport_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 18);
            this.label12.TabIndex = 29;
            this.label12.Text = "Report Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Report Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Officer  in Charge";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rtbcomplain);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtoccu);
            this.groupBox1.Controls.Add(this.cmbstate);
            this.groupBox1.Controls.Add(this.cmbhair);
            this.groupBox1.Controls.Add(this.cmbcomplex);
            this.groupBox1.Controls.Add(this.cmbeye);
            this.groupBox1.Controls.Add(this.cmbsex);
            this.groupBox1.Controls.Add(this.rtbaddress);
            this.groupBox1.Controls.Add(this.txtphone);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 433);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complainant Details";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(95, 210);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(113, 22);
            this.txtage.TabIndex = 49;
            this.txtage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtage_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 48;
            this.label2.Text = "Age";
            // 
            // rtbcomplain
            // 
            this.rtbcomplain.Location = new System.Drawing.Point(95, 325);
            this.rtbcomplain.Name = "rtbcomplain";
            this.rtbcomplain.Size = new System.Drawing.Size(338, 65);
            this.rtbcomplain.TabIndex = 45;
            this.rtbcomplain.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Complain";
            // 
            // txtoccu
            // 
            this.txtoccu.Location = new System.Drawing.Point(106, 71);
            this.txtoccu.Name = "txtoccu";
            this.txtoccu.Size = new System.Drawing.Size(327, 22);
            this.txtoccu.TabIndex = 42;
            this.txtoccu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoccu_KeyPress);
            // 
            // cmbstate
            // 
            this.cmbstate.FormattingEnabled = true;
            this.cmbstate.Items.AddRange(new object[] {
            "Abia State",
            "Adamawa State",
            "Akwa Ibom State",
            "Anambra State",
            "Bauchi State",
            "Bayelsa State",
            "Benue State",
            "Borno State",
            "Cross River State",
            "Delta State",
            "Ebonyi State",
            "Edo State",
            "Ekiti State",
            "Enugu State",
            "Federal Capital Territory",
            "Gombe State",
            "Imo State",
            "Jigawa State",
            "Kaduna State",
            "Kano State",
            "Katsina State",
            "Kebbi State",
            "Kogi State",
            "Kwara State",
            "Lagos State",
            "Nasarawa State",
            "Niger State",
            "Ogun State",
            "Ondo State",
            "Osun State",
            "Oyo State",
            "Plateau State",
            "Rivers State",
            "Sokoto State",
            "Taraba State",
            "Yobe State",
            "Zamfara State"});
            this.cmbstate.Location = new System.Drawing.Point(283, 214);
            this.cmbstate.Name = "cmbstate";
            this.cmbstate.Size = new System.Drawing.Size(150, 24);
            this.cmbstate.TabIndex = 41;
            // 
            // cmbcomplex
            // 
            this.cmbcomplex.FormattingEnabled = true;
            this.cmbcomplex.Items.AddRange(new object[] {
            "Black",
            "White",
            "Albino"});
            this.cmbcomplex.Location = new System.Drawing.Point(105, 165);
            this.cmbcomplex.Name = "cmbcomplex";
            this.cmbcomplex.Size = new System.Drawing.Size(103, 24);
            this.cmbcomplex.TabIndex = 38;
            // 
            // cmbeye
            // 
            this.cmbeye.FormattingEnabled = true;
            this.cmbeye.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Yellow",
            "Green",
            "Brown"});
            this.cmbeye.Location = new System.Drawing.Point(307, 122);
            this.cmbeye.Name = "cmbeye";
            this.cmbeye.Size = new System.Drawing.Size(126, 24);
            this.cmbeye.TabIndex = 37;
            // 
            // cmbsex
            // 
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbsex.Location = new System.Drawing.Point(64, 122);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(100, 24);
            this.cmbsex.TabIndex = 36;
            // 
            // rtbaddress
            // 
            this.rtbaddress.Location = new System.Drawing.Point(95, 244);
            this.rtbaddress.Name = "rtbaddress";
            this.rtbaddress.Size = new System.Drawing.Size(338, 75);
            this.rtbaddress.TabIndex = 34;
            this.rtbaddress.Text = "";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(95, 404);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(338, 22);
            this.txtphone.TabIndex = 33;
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(230, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 18);
            this.label16.TabIndex = 33;
            this.label16.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "EyeColour";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(64, 27);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(369, 22);
            this.txtname.TabIndex = 28;
            this.txtname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtname_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Sex";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 18);
            this.label11.TabIndex = 28;
            this.label11.Text = "Address";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 405);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 18);
            this.label15.TabIndex = 32;
            this.label15.Text = "Telephone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(230, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Hair Colour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Complexion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Occupation";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(900, 9);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(58, 18);
            this.lbluser.TabIndex = 48;
            this.lbluser.Text = "lbluser";
            // 
            // cmbhair
            // 
            this.cmbhair.FormattingEnabled = true;
            this.cmbhair.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Yellow",
            "Green",
            "Brown"});
            this.cmbhair.Location = new System.Drawing.Point(338, 167);
            this.cmbhair.Name = "cmbhair";
            this.cmbhair.Size = new System.Drawing.Size(102, 24);
            this.cmbhair.TabIndex = 39;
            // 
            // complainant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(893, 472);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "complainant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "complainant";
            this.Load += new System.EventHandler(this.complainant_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtoffice;
        private System.Windows.Forms.DateTimePicker dtpRTime;
        private System.Windows.Forms.DateTimePicker dtpreport;
        private System.Windows.Forms.RichTextBox rtbcomplain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtoccu;
        private System.Windows.Forms.ComboBox cmbstate;
        private System.Windows.Forms.ComboBox cmbcomplex;
        private System.Windows.Forms.ComboBox cmbeye;
        private System.Windows.Forms.ComboBox cmbsex;
        private System.Windows.Forms.RichTextBox rtbaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbhair;
    }
}