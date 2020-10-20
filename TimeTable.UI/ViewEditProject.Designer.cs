
namespace TimeTable.UI
{
    partial class ViewEditProject
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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.npMaxHours = new System.Windows.Forms.NumericUpDown();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridViewProjectMonths = new System.Windows.Forms.DataGridView();
            this.clmPmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPmFinish = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.npPmMonth = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.npPmYear = new System.Windows.Forms.NumericUpDown();
            this.btnAddProjectMonth = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npMaxHours)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProjectMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npPmMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npPmYear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.npMaxHours);
            this.groupBox1.Controls.Add(this.dpEnd);
            this.groupBox1.Controls.Add(this.dpStart);
            this.groupBox1.Controls.Add(this.txtProjectDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProjectName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 391);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данни за проект";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(226, 330);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(265, 28);
            this.cmbStatus.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Статус";
            // 
            // npMaxHours
            // 
            this.npMaxHours.Location = new System.Drawing.Point(226, 263);
            this.npMaxHours.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.npMaxHours.Name = "npMaxHours";
            this.npMaxHours.Size = new System.Drawing.Size(100, 27);
            this.npMaxHours.TabIndex = 5;
            // 
            // dpEnd
            // 
            this.dpEnd.Location = new System.Drawing.Point(226, 211);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(265, 27);
            this.dpEnd.TabIndex = 4;
            // 
            // dpStart
            // 
            this.dpStart.Location = new System.Drawing.Point(226, 160);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(265, 27);
            this.dpStart.TabIndex = 3;
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(226, 84);
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.Size = new System.Drawing.Size(265, 58);
            this.txtProjectDescription.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Максимален брой\r\nчасове";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Край";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Начало";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(226, 39);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(265, 27);
            this.txtProjectName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(388, 409);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отказ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 409);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Запази";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridViewProjectMonths);
            this.groupBox2.Location = new System.Drawing.Point(516, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 390);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отчетни месеци";
            // 
            // gridViewProjectMonths
            // 
            this.gridViewProjectMonths.AllowUserToAddRows = false;
            this.gridViewProjectMonths.AllowUserToDeleteRows = false;
            this.gridViewProjectMonths.AllowUserToResizeColumns = false;
            this.gridViewProjectMonths.AllowUserToResizeRows = false;
            this.gridViewProjectMonths.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewProjectMonths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProjectMonths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPmMonth,
            this.clmPmYear,
            this.clmPmStatus,
            this.clmEmployees,
            this.clmHours,
            this.clmPmFinish});
            this.gridViewProjectMonths.Location = new System.Drawing.Point(3, 23);
            this.gridViewProjectMonths.Name = "gridViewProjectMonths";
            this.gridViewProjectMonths.RowHeadersVisible = false;
            this.gridViewProjectMonths.RowHeadersWidth = 51;
            this.gridViewProjectMonths.RowTemplate.Height = 29;
            this.gridViewProjectMonths.Size = new System.Drawing.Size(759, 361);
            this.gridViewProjectMonths.TabIndex = 0;
            this.gridViewProjectMonths.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewProjectMonths_CellContentClick);
            // 
            // clmPmMonth
            // 
            this.clmPmMonth.DataPropertyName = "ProjectMonth";
            this.clmPmMonth.HeaderText = "Месец";
            this.clmPmMonth.MinimumWidth = 6;
            this.clmPmMonth.Name = "clmPmMonth";
            this.clmPmMonth.ReadOnly = true;
            // 
            // clmPmYear
            // 
            this.clmPmYear.DataPropertyName = "ProjectYear";
            this.clmPmYear.HeaderText = "Година";
            this.clmPmYear.MinimumWidth = 6;
            this.clmPmYear.Name = "clmPmYear";
            this.clmPmYear.ReadOnly = true;
            // 
            // clmPmStatus
            // 
            this.clmPmStatus.DataPropertyName = "FullStatus";
            this.clmPmStatus.HeaderText = "Статус";
            this.clmPmStatus.MinimumWidth = 6;
            this.clmPmStatus.Name = "clmPmStatus";
            this.clmPmStatus.ReadOnly = true;
            // 
            // clmEmployees
            // 
            this.clmEmployees.DataPropertyName = "EmployeeCount";
            this.clmEmployees.HeaderText = "Брой служители";
            this.clmEmployees.MinimumWidth = 6;
            this.clmEmployees.Name = "clmEmployees";
            this.clmEmployees.ReadOnly = true;
            // 
            // clmHours
            // 
            this.clmHours.DataPropertyName = "HourSum";
            this.clmHours.HeaderText = "Общо часове";
            this.clmHours.MinimumWidth = 6;
            this.clmHours.Name = "clmHours";
            this.clmHours.ReadOnly = true;
            // 
            // clmPmFinish
            // 
            this.clmPmFinish.HeaderText = " ";
            this.clmPmFinish.MinimumWidth = 6;
            this.clmPmFinish.Name = "clmPmFinish";
            this.clmPmFinish.ReadOnly = true;
            this.clmPmFinish.Text = "приключи";
            this.clmPmFinish.UseColumnTextForButtonValue = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(806, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Месец";
            // 
            // npPmMonth
            // 
            this.npPmMonth.Location = new System.Drawing.Point(866, 411);
            this.npPmMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.npPmMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npPmMonth.Name = "npPmMonth";
            this.npPmMonth.Size = new System.Drawing.Size(65, 27);
            this.npPmMonth.TabIndex = 11;
            this.npPmMonth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(976, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Година";
            // 
            // npPmYear
            // 
            this.npPmYear.Location = new System.Drawing.Point(1060, 411);
            this.npPmYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.npPmYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.npPmYear.Name = "npPmYear";
            this.npPmYear.Size = new System.Drawing.Size(82, 27);
            this.npPmYear.TabIndex = 13;
            this.npPmYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // btnAddProjectMonth
            // 
            this.btnAddProjectMonth.Location = new System.Drawing.Point(1184, 409);
            this.btnAddProjectMonth.Name = "btnAddProjectMonth";
            this.btnAddProjectMonth.Size = new System.Drawing.Size(94, 29);
            this.btnAddProjectMonth.TabIndex = 14;
            this.btnAddProjectMonth.Text = "Добави";
            this.btnAddProjectMonth.UseVisualStyleBackColor = true;
            this.btnAddProjectMonth.Click += new System.EventHandler(this.btnAddProjectMonth_Click);
            // 
            // ViewEditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 450);
            this.Controls.Add(this.btnAddProjectMonth);
            this.Controls.Add(this.npPmYear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.npPmMonth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewEditProject";
            this.Text = "Година";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npMaxHours)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProjectMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npPmMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npPmYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown npMaxHours;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridViewProjectMonths;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown npPmMonth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown npPmYear;
        private System.Windows.Forms.Button btnAddProjectMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHours;
        private System.Windows.Forms.DataGridViewButtonColumn clmPmFinish;
    }
}