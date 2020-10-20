
namespace TimeTable.UI
{
    partial class EmployeeTime
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
            this.dataGridEmployeeHours = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.npHours = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddTime = new System.Windows.Forms.Button();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployeeHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npHours)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridEmployeeHours);
            this.groupBox1.Location = new System.Drawing.Point(12, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1131, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Време на служител";
            // 
            // dataGridEmployeeHours
            // 
            this.dataGridEmployeeHours.AllowUserToAddRows = false;
            this.dataGridEmployeeHours.AllowUserToDeleteRows = false;
            this.dataGridEmployeeHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmployeeHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployeeHours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDate,
            this.clmProject,
            this.clmTask,
            this.clmHours,
            this.clmEdit,
            this.clmDelete});
            this.dataGridEmployeeHours.Location = new System.Drawing.Point(7, 27);
            this.dataGridEmployeeHours.Name = "dataGridEmployeeHours";
            this.dataGridEmployeeHours.RowHeadersWidth = 51;
            this.dataGridEmployeeHours.RowTemplate.Height = 29;
            this.dataGridEmployeeHours.Size = new System.Drawing.Size(1118, 392);
            this.dataGridEmployeeHours.TabIndex = 0;
            this.dataGridEmployeeHours.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployeeHours_CellContentClick);
            this.dataGridEmployeeHours.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployeeHours_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата";
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(110, 32);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(250, 27);
            this.dpDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Проект";
            // 
            // cmbProject
            // 
            this.cmbProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(110, 89);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(250, 28);
            this.cmbProject.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дейност";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(110, 146);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(250, 27);
            this.txtTask.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Часове";
            // 
            // npHours
            // 
            this.npHours.Location = new System.Drawing.Point(110, 200);
            this.npHours.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.npHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npHours.Name = "npHours";
            this.npHours.Size = new System.Drawing.Size(150, 27);
            this.npHours.TabIndex = 8;
            this.npHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddTime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.npHours);
            this.groupBox2.Controls.Add(this.dpDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTask);
            this.groupBox2.Controls.Add(this.cmbProject);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(19, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 296);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добави време";
            // 
            // btnAddTime
            // 
            this.btnAddTime.Location = new System.Drawing.Point(266, 253);
            this.btnAddTime.Name = "btnAddTime";
            this.btnAddTime.Size = new System.Drawing.Size(94, 29);
            this.btnAddTime.TabIndex = 9;
            this.btnAddTime.Text = "Добави";
            this.btnAddTime.UseVisualStyleBackColor = true;
            this.btnAddTime.Click += new System.EventHandler(this.btnAddTime_Click);
            // 
            // clmDate
            // 
            this.clmDate.DataPropertyName = "Date";
            this.clmDate.HeaderText = "Дата";
            this.clmDate.MinimumWidth = 6;
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // clmProject
            // 
            this.clmProject.DataPropertyName = "Project";
            this.clmProject.HeaderText = "Проект";
            this.clmProject.MinimumWidth = 6;
            this.clmProject.Name = "clmProject";
            this.clmProject.ReadOnly = true;
            // 
            // clmTask
            // 
            this.clmTask.DataPropertyName = "Task";
            this.clmTask.HeaderText = "Описание на дейността";
            this.clmTask.MinimumWidth = 6;
            this.clmTask.Name = "clmTask";
            this.clmTask.ReadOnly = true;
            // 
            // clmHours
            // 
            this.clmHours.DataPropertyName = "Hours";
            this.clmHours.HeaderText = "Часове";
            this.clmHours.MinimumWidth = 6;
            this.clmHours.Name = "clmHours";
            this.clmHours.ReadOnly = true;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = " ";
            this.clmEdit.MinimumWidth = 6;
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Text = "редактирай";
            this.clmEdit.UseColumnTextForButtonValue = true;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "  ";
            this.clmDelete.MinimumWidth = 6;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Text = "изтрий";
            this.clmDelete.UseColumnTextForButtonValue = true;
            // 
            // EmployeeTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 751);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeTime";
            this.Text = "Отработено време";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployeeHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npHours)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridEmployeeHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown npHours;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHours;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmDelete;
    }
}