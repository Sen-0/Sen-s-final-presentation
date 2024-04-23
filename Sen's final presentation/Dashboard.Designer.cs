namespace Sen_s_final_presentation
{
    partial class Control_Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Tot_emp_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.guna2Panel2.Controls.Add(this.Tot_emp_label);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Location = new System.Drawing.Point(55, 236);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(581, 202);
            this.guna2Panel2.TabIndex = 0;
            // 
            // Tot_emp_label
            // 
            this.Tot_emp_label.BackColor = System.Drawing.Color.Transparent;
            this.Tot_emp_label.Font = new System.Drawing.Font("Nirmala UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tot_emp_label.ForeColor = System.Drawing.Color.White;
            this.Tot_emp_label.Location = new System.Drawing.Point(429, 74);
            this.Tot_emp_label.Name = "Tot_emp_label";
            this.Tot_emp_label.Size = new System.Drawing.Size(58, 130);
            this.Tot_emp_label.TabIndex = 1;
            this.Tot_emp_label.Text = "0";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 120);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(374, 67);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Total Employees";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Sen_s_final_presentation.Properties.Resources.person1;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(24, 44);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(188, 168);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(218, 161);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(360, 34);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Employee Management System";
            // 
            // Control_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Name = "Control_Dashboard";
            this.Size = new System.Drawing.Size(684, 561);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel Tot_emp_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}
