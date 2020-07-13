namespace CCTIS
{
    partial class ComplainantList
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
            this.components = new System.ComponentModel.Container();
            this.btnview = new System.Windows.Forms.Button();
            this.complainantListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.complainantListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(1020, 445);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(120, 32);
            this.btnview.TabIndex = 1;
            this.btnview.Text = "View List";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 439);
            this.dataGridView1.TabIndex = 2;
            // 
            // ComplainantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnview);
            this.MinimizeBox = false;
            this.Name = "ComplainantList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCTIS- Complainant List";
            this.Load += new System.EventHandler(this.ComplainantList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.complainantListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.BindingSource complainantListBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}