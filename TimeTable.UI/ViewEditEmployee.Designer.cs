
namespace TimeTable.UI
{
    partial class ViewEditEmployee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpHireDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFamilyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEgn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridEmployeeMonth = new System.Windows.Forms.DataGridView();
            this.clmProjectMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonthHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridProjectTime = new System.Windows.Forms.DataGridView();
            this.clmProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployeeMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjectTime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpHireDate);
            this.groupBox1.Controls.Add(this.cmbPosition);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtFamilyName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEgn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 336);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данни на служител";
            // 
            // dpHireDate
            // 
            this.dpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpHireDate.Location = new System.Drawing.Point(186, 280);
            this.dpHireDate.Name = "dpHireDate";
            this.dpHireDate.Size = new System.Drawing.Size(191, 27);
            this.dpHireDate.TabIndex = 6;
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(186, 232);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(191, 28);
            this.cmbPosition.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Дата на постъпване";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Длъжност";
            // 
            // txtFamilyName
            // 
            this.txtFamilyName.Location = new System.Drawing.Point(186, 183);
            this.txtFamilyName.Name = "txtFamilyName";
            this.txtFamilyName.Size = new System.Drawing.Size(191, 27);
            this.txtFamilyName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Фамилия";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(186, 133);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(191, 27);
            this.txtSurname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Презиме";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(186, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 27);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Име";
            // 
            // txtEgn
            // 
            this.txtEgn.Location = new System.Drawing.Point(186, 36);
            this.txtEgn.Name = "txtEgn";
            this.txtEgn.Size = new System.Drawing.Size(191, 27);
            this.txtEgn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ЕГН";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отказ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridEmployeeMonth);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dataGridProjectTime);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(403, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(883, 335);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отработено време";
            // 
            // dataGridEmployeeMonth
            // 
            this.dataGridEmployeeMonth.AllowUserToAddRows = false;
            this.dataGridEmployeeMonth.AllowUserToDeleteRows = false;
            this.dataGridEmployeeMonth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmployeeMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployeeMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProjectMonth,
            this.clmProjectYear,
            this.clmMonthHours});
            this.dataGridEmployeeMonth.Location = new System.Drawing.Point(450, 60);
            this.dataGridEmployeeMonth.Name = "dataGridEmployeeMonth";
            this.dataGridEmployeeMonth.RowHeadersWidth = 51;
            this.dataGridEmployeeMonth.RowTemplate.Height = 29;
            this.dataGridEmployeeMonth.Size = new System.Drawing.Size(427, 269);
            this.dataGridEmployeeMonth.TabIndex = 3;
            // 
            // clmProjectMonth
            // 
            this.clmProjectMonth.DataPropertyName = "ProjectMonth";
            this.clmProjectMonth.HeaderText = "Месец";
            this.clmProjectMonth.MinimumWidth = 6;
            this.clmProjectMonth.Name = "clmProjectMonth";
            this.clmProjectMonth.ReadOnly = true;
            // 
            // clmProjectYear
            // 
            this.clmProjectYear.DataPropertyName = "ProjectYear";
            this.clmProjectYear.HeaderText = "Година";
            this.clmProjectYear.MinimumWidth = 6;
            this.clmProjectYear.Name = "clmProjectYear";
            this.clmProjectYear.ReadOnly = true;
            // 
            // clmMonthHours
            // 
            this.clmMonthHours.DataPropertyName = "Hours";
            this.clmMonthHours.HeaderText = "Часове";
            this.clmMonthHours.MinimumWidth = 6;
            this.clmMonthHours.Name = "clmMonthHours";
            this.clmMonthHours.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "По месец/година";
            // 
            // dataGridProjectTime
            // 
            this.dataGridProjectTime.AllowUserToAddRows = false;
            this.dataGridProjectTime.AllowUserToDeleteRows = false;
            this.dataGridProjectTime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProjectTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProjectTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProject,
            this.clmProjectHours});
            this.dataGridProjectTime.Location = new System.Drawing.Point(7, 60);
            this.dataGridProjectTime.Name = "dataGridProjectTime";
            this.dataGridProjectTime.RowHeadersWidth = 51;
            this.dataGridProjectTime.RowTemplate.Height = 29;
            this.dataGridProjectTime.Size = new System.Drawing.Size(420, 269);
            this.dataGridProjectTime.TabIndex = 1;
            // 
            // clmProject
            // 
            this.clmProject.DataPropertyName = "ProjectName";
            this.clmProject.HeaderText = "Проект";
            this.clmProject.MinimumWidth = 6;
            this.clmProject.Name = "clmProject";
            this.clmProject.ReadOnly = true;
            // 
            // clmProjectHours
            // 
            this.clmProjectHours.DataPropertyName = "Hours";
            this.clmProjectHours.HeaderText = "Часове";
            this.clmProjectHours.MinimumWidth = 6;
            this.clmProjectHours.Name = "clmProjectHours";
            this.clmProjectHours.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "По проект";
            // 
            // ViewEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewEditEmployee";
            this.Text = "Преглед/редакция на служител";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployeeMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjectTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpHireDate;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFamilyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEgn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridProjectTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectHours;
        private System.Windows.Forms.DataGridView dataGridEmployeeMonth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonthHours;
    }
}