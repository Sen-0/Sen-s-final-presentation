namespace Sen_s_final_presentation
{
    partial class Salary
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.eMSDataSet2 = new Sen_s_final_presentation.EMSDataSet2();
            this.eMSDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMSDataSet3 = new Sen_s_final_presentation.EMSDataSet3();
            this.eMPLOYEEFIRSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEE_FIRSTTableAdapter = new Sen_s_final_presentation.EMSDataSet3TableAdapters.EMPLOYEE_FIRSTTableAdapter();
            this.eMSDataSet4 = new Sen_s_final_presentation.EMSDataSet4();
            this.eMPLOYEEFIRSTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYEE_FIRSTTableAdapter1 = new Sen_s_final_presentation.EMSDataSet4TableAdapters.EMPLOYEE_FIRSTTableAdapter();
            this.eMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPJOBPOSITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_SALARY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Employee_IDbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Salary_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEFIRSTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEFIRSTBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2DataGridView1);
            this.panel1.Location = new System.Drawing.Point(315, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 506);
            this.panel1.TabIndex = 0;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eMPIDDataGridViewTextBoxColumn,
            this.eMPNAMEDataGridViewTextBoxColumn,
            this.eMPJOBPOSITIONDataGridViewTextBoxColumn,
            this.EMP_SALARY});
            this.guna2DataGridView1.DataSource = this.eMPLOYEEFIRSTBindingSource1;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle15;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.Size = new System.Drawing.Size(346, 506);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 28;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            // 
            // eMSDataSet2
            // 
            this.eMSDataSet2.DataSetName = "EMSDataSet2";
            this.eMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMSDataSet2BindingSource
            // 
            this.eMSDataSet2BindingSource.DataSource = this.eMSDataSet2;
            this.eMSDataSet2BindingSource.Position = 0;
            // 
            // eMSDataSet3
            // 
            this.eMSDataSet3.DataSetName = "EMSDataSet3";
            this.eMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEEFIRSTBindingSource
            // 
            this.eMPLOYEEFIRSTBindingSource.DataMember = "EMPLOYEE_FIRST";
            this.eMPLOYEEFIRSTBindingSource.DataSource = this.eMSDataSet3;
            // 
            // eMPLOYEE_FIRSTTableAdapter
            // 
            this.eMPLOYEE_FIRSTTableAdapter.ClearBeforeFill = true;
            // 
            // eMSDataSet4
            // 
            this.eMSDataSet4.DataSetName = "EMSDataSet4";
            this.eMSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eMPLOYEEFIRSTBindingSource1
            // 
            this.eMPLOYEEFIRSTBindingSource1.DataMember = "EMPLOYEE_FIRST";
            this.eMPLOYEEFIRSTBindingSource1.DataSource = this.eMSDataSet4;
            // 
            // eMPLOYEE_FIRSTTableAdapter1
            // 
            this.eMPLOYEE_FIRSTTableAdapter1.ClearBeforeFill = true;
            // 
            // eMPIDDataGridViewTextBoxColumn
            // 
            this.eMPIDDataGridViewTextBoxColumn.DataPropertyName = "EMP_ID";
            this.eMPIDDataGridViewTextBoxColumn.HeaderText = "Employee ID";
            this.eMPIDDataGridViewTextBoxColumn.Name = "eMPIDDataGridViewTextBoxColumn";
            this.eMPIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // eMPNAMEDataGridViewTextBoxColumn
            // 
            this.eMPNAMEDataGridViewTextBoxColumn.DataPropertyName = "EMP_NAME";
            this.eMPNAMEDataGridViewTextBoxColumn.HeaderText = "Employee Name";
            this.eMPNAMEDataGridViewTextBoxColumn.Name = "eMPNAMEDataGridViewTextBoxColumn";
            this.eMPNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPNAMEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // eMPJOBPOSITIONDataGridViewTextBoxColumn
            // 
            this.eMPJOBPOSITIONDataGridViewTextBoxColumn.DataPropertyName = "EMP_JOB_POSITION";
            this.eMPJOBPOSITIONDataGridViewTextBoxColumn.HeaderText = "Employee Job Position";
            this.eMPJOBPOSITIONDataGridViewTextBoxColumn.Name = "eMPJOBPOSITIONDataGridViewTextBoxColumn";
            this.eMPJOBPOSITIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMPJOBPOSITIONDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EMP_SALARY
            // 
            this.EMP_SALARY.DataPropertyName = "EMP_SALARY";
            this.EMP_SALARY.HeaderText = "Employee Salary";
            this.EMP_SALARY.Name = "EMP_SALARY";
            this.EMP_SALARY.ReadOnly = true;
            this.EMP_SALARY.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(70, 341);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "UPDATE";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Employee_IDbox
            // 
            this.Employee_IDbox.Animated = true;
            this.Employee_IDbox.AutoRoundedCorners = true;
            this.Employee_IDbox.BorderRadius = 17;
            this.Employee_IDbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Employee_IDbox.DefaultText = "";
            this.Employee_IDbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Employee_IDbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Employee_IDbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Employee_IDbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Employee_IDbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Employee_IDbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Employee_IDbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.Employee_IDbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Employee_IDbox.Location = new System.Drawing.Point(64, 124);
            this.Employee_IDbox.Name = "Employee_IDbox";
            this.Employee_IDbox.PasswordChar = '\0';
            this.Employee_IDbox.PlaceholderText = "";
            this.Employee_IDbox.SelectedText = "";
            this.Employee_IDbox.Size = new System.Drawing.Size(200, 36);
            this.Employee_IDbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.label1.Location = new System.Drawing.Point(61, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "User ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.label4.Location = new System.Drawing.Point(61, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Salary";
            // 
            // Salary_Box
            // 
            this.Salary_Box.Animated = true;
            this.Salary_Box.AutoRoundedCorners = true;
            this.Salary_Box.BorderRadius = 17;
            this.Salary_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Salary_Box.DefaultText = "";
            this.Salary_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Salary_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Salary_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Salary_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Salary_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Salary_Box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Salary_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.Salary_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Salary_Box.Location = new System.Drawing.Point(64, 221);
            this.Salary_Box.Name = "Salary_Box";
            this.Salary_Box.PasswordChar = '\0';
            this.Salary_Box.PlaceholderText = "";
            this.Salary_Box.SelectedText = "";
            this.Salary_Box.Size = new System.Drawing.Size(200, 36);
            this.Salary_Box.TabIndex = 9;
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(138)))), ((int)(((byte)(173)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(70, 419);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 11;
            this.guna2Button2.Text = "DELETE";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Salary_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employee_IDbox);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(684, 561);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEFIRSTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYEEFIRSTBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.BindingSource eMPLOYEEFIRSTBindingSource;
        private EMSDataSet3 eMSDataSet3;
        private EMSDataSet2 eMSDataSet2;
        private System.Windows.Forms.BindingSource eMSDataSet2BindingSource;
        private EMSDataSet3TableAdapters.EMPLOYEE_FIRSTTableAdapter eMPLOYEE_FIRSTTableAdapter;
        private System.Windows.Forms.BindingSource eMPLOYEEFIRSTBindingSource1;
        private EMSDataSet4 eMSDataSet4;
        private EMSDataSet4TableAdapters.EMPLOYEE_FIRSTTableAdapter eMPLOYEE_FIRSTTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMPJOBPOSITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_SALARY;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox Employee_IDbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox Salary_Box;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}
