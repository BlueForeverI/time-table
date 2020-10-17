﻿
namespace TimeTable.UI
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.cmbSearchEmployeeType = new System.Windows.Forms.ComboBox();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dataGridEmployees = new System.Windows.Forms.DataGridView();
            this.clmEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEgn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHireData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.dataGridProjects = new System.Windows.Forms.DataGridView();
            this.clmProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearEmployeeSearch = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1157, 636);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnClearEmployeeSearch);
            this.tabPage1.Controls.Add(this.btnSearchEmployee);
            this.tabPage1.Controls.Add(this.cmbSearchEmployeeType);
            this.tabPage1.Controls.Add(this.txtSearchEmployee);
            this.tabPage1.Controls.Add(this.btnAddEmployee);
            this.tabPage1.Controls.Add(this.dataGridEmployees);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1149, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Служители";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(531, 35);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(94, 30);
            this.btnSearchEmployee.TabIndex = 4;
            this.btnSearchEmployee.Text = "Търси";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // cmbSearchEmployeeType
            // 
            this.cmbSearchEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchEmployeeType.FormattingEnabled = true;
            this.cmbSearchEmployeeType.Location = new System.Drawing.Point(305, 37);
            this.cmbSearchEmployeeType.Name = "cmbSearchEmployeeType";
            this.cmbSearchEmployeeType.Size = new System.Drawing.Size(220, 28);
            this.cmbSearchEmployeeType.TabIndex = 3;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(4, 38);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(295, 27);
            this.txtSearchEmployee.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(1052, 571);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(94, 29);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Добави";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // dataGridEmployees
            // 
            this.dataGridEmployees.AllowUserToAddRows = false;
            this.dataGridEmployees.AllowUserToDeleteRows = false;
            this.dataGridEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmEmployeeId,
            this.clmEgn,
            this.clmName,
            this.clmSurname,
            this.clmFamilyName,
            this.clmPosition,
            this.clmHireData});
            this.dataGridEmployees.Location = new System.Drawing.Point(3, 96);
            this.dataGridEmployees.Name = "dataGridEmployees";
            this.dataGridEmployees.RowHeadersWidth = 51;
            this.dataGridEmployees.Size = new System.Drawing.Size(1143, 469);
            this.dataGridEmployees.TabIndex = 0;
            // 
            // clmEmployeeId
            // 
            this.clmEmployeeId.DataPropertyName = "EmployeeId";
            this.clmEmployeeId.HeaderText = "ID";
            this.clmEmployeeId.MinimumWidth = 6;
            this.clmEmployeeId.Name = "clmEmployeeId";
            this.clmEmployeeId.ReadOnly = true;
            // 
            // clmEgn
            // 
            this.clmEgn.DataPropertyName = "EmployeeEgn";
            this.clmEgn.HeaderText = "ЕГН";
            this.clmEgn.MinimumWidth = 6;
            this.clmEgn.Name = "clmEgn";
            this.clmEgn.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "EmployeeName";
            this.clmName.HeaderText = "Име";
            this.clmName.MinimumWidth = 6;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmSurname
            // 
            this.clmSurname.DataPropertyName = "EmployeeSurname";
            this.clmSurname.HeaderText = "Презиме";
            this.clmSurname.MinimumWidth = 6;
            this.clmSurname.Name = "clmSurname";
            this.clmSurname.ReadOnly = true;
            // 
            // clmFamilyName
            // 
            this.clmFamilyName.DataPropertyName = "EmployeeLastname";
            this.clmFamilyName.HeaderText = "Фамилия";
            this.clmFamilyName.MinimumWidth = 6;
            this.clmFamilyName.Name = "clmFamilyName";
            this.clmFamilyName.ReadOnly = true;
            // 
            // clmPosition
            // 
            this.clmPosition.DataPropertyName = "EmployeePosition";
            this.clmPosition.HeaderText = "Длъжност";
            this.clmPosition.MinimumWidth = 6;
            this.clmPosition.Name = "clmPosition";
            this.clmPosition.ReadOnly = true;
            // 
            // clmHireData
            // 
            this.clmHireData.DataPropertyName = "EmployeeHiredate";
            this.clmHireData.HeaderText = "Дата на постъпване";
            this.clmHireData.MinimumWidth = 6;
            this.clmHireData.Name = "clmHireData";
            this.clmHireData.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddProject);
            this.tabPage2.Controls.Add(this.dataGridProjects);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1149, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Проекти";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(1051, 570);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(94, 29);
            this.btnAddProject.TabIndex = 1;
            this.btnAddProject.Text = "Добави";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // dataGridProjects
            // 
            this.dataGridProjects.AllowUserToAddRows = false;
            this.dataGridProjects.AllowUserToDeleteRows = false;
            this.dataGridProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProjectId,
            this.clmProjectname,
            this.clmProjectStart,
            this.clmProjectEnd,
            this.clmProjectDescription,
            this.clmProjectStatus});
            this.dataGridProjects.Location = new System.Drawing.Point(3, 3);
            this.dataGridProjects.Name = "dataGridProjects";
            this.dataGridProjects.ReadOnly = true;
            this.dataGridProjects.RowHeadersWidth = 51;
            this.dataGridProjects.Size = new System.Drawing.Size(1143, 560);
            this.dataGridProjects.TabIndex = 0;
            // 
            // clmProjectId
            // 
            this.clmProjectId.DataPropertyName = "ProjectId";
            this.clmProjectId.HeaderText = "ID";
            this.clmProjectId.MinimumWidth = 6;
            this.clmProjectId.Name = "clmProjectId";
            this.clmProjectId.ReadOnly = true;
            // 
            // clmProjectname
            // 
            this.clmProjectname.DataPropertyName = "ProjectName";
            this.clmProjectname.HeaderText = "Име";
            this.clmProjectname.MinimumWidth = 6;
            this.clmProjectname.Name = "clmProjectname";
            this.clmProjectname.ReadOnly = true;
            // 
            // clmProjectStart
            // 
            this.clmProjectStart.DataPropertyName = "ProjectBegin";
            this.clmProjectStart.HeaderText = "Начало";
            this.clmProjectStart.MinimumWidth = 6;
            this.clmProjectStart.Name = "clmProjectStart";
            this.clmProjectStart.ReadOnly = true;
            // 
            // clmProjectEnd
            // 
            this.clmProjectEnd.DataPropertyName = "ProjectEnd";
            this.clmProjectEnd.HeaderText = "Край";
            this.clmProjectEnd.MinimumWidth = 6;
            this.clmProjectEnd.Name = "clmProjectEnd";
            this.clmProjectEnd.ReadOnly = true;
            // 
            // clmProjectDescription
            // 
            this.clmProjectDescription.DataPropertyName = "ProjectDescription";
            this.clmProjectDescription.HeaderText = "Описание";
            this.clmProjectDescription.MinimumWidth = 6;
            this.clmProjectDescription.Name = "clmProjectDescription";
            this.clmProjectDescription.ReadOnly = true;
            // 
            // clmProjectStatus
            // 
            this.clmProjectStatus.DataPropertyName = "ProjectStatus";
            this.clmProjectStatus.HeaderText = "Статус";
            this.clmProjectStatus.MinimumWidth = 6;
            this.clmProjectStatus.Name = "clmProjectStatus";
            this.clmProjectStatus.ReadOnly = true;
            // 
            // btnClearEmployeeSearch
            // 
            this.btnClearEmployeeSearch.Location = new System.Drawing.Point(631, 35);
            this.btnClearEmployeeSearch.Name = "btnClearEmployeeSearch";
            this.btnClearEmployeeSearch.Size = new System.Drawing.Size(94, 29);
            this.btnClearEmployeeSearch.TabIndex = 5;
            this.btnClearEmployeeSearch.Text = "Изчисти";
            this.btnClearEmployeeSearch.UseVisualStyleBackColor = true;
            this.btnClearEmployeeSearch.Click += new System.EventHandler(this.btnClearEmployeeSearch_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 661);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Отчитане на отработено време";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridEmployees;
        private System.Windows.Forms.DataGridView dataGridProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectStatus;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEgn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHireData;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.ComboBox cmbSearchEmployeeType;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Button btnClearEmployeeSearch;
    }
}