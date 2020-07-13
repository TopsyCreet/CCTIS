namespace CCTIS
{
    partial class fingerprint
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
            this.first = new System.Windows.Forms.Button();
            this.compare = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(31, 22);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(138, 27);
            this.first.TabIndex = 0;
            this.first.Text = "First Finger";
            this.first.UseVisualStyleBackColor = true;
           // this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // compare
            // 
            this.compare.Location = new System.Drawing.Point(203, 378);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(185, 42);
            this.compare.TabIndex = 1;
            this.compare.Text = "compare";
            this.compare.UseVisualStyleBackColor = true;
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(361, 22);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(179, 31);
            this.second.TabIndex = 2;
            this.second.Text = "Second Finger";
            this.second.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(31, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 231);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(343, 90);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 231);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // fingerprint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 455);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.second);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.first);
            this.Name = "fingerprint";
            this.Text = "fingerprint";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fingerprint_FormClosed);
           // this.Load += new System.EventHandler(this.fingerprint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.Button second;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}