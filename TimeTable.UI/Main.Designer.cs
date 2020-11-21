
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
            this.dpEmployeeSearchHireDate = new System.Windows.Forms.DateTimePicker();
            this.cmbEmployeeSerachPosition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchEmployeeEgn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSearchSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearEmployeeSearch = new System.Windows.Forms.Button();
            this.btnSearchEmployee = new System.Windows.Forms.Button();
            this.txtEmployeeSerchLastName = new System.Windows.Forms.TextBox();
            this.txtSearchEmployeeSurname = new System.Windows.Forms.TextBox();
            this.txtSearchEmployeeName = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.dataGridEmployees = new System.Windows.Forms.DataGridView();
            this.clmEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEgn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHireData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmEmployeeTime = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClearProjectSearch = new System.Windows.Forms.Button();
            this.btnSearchProject = new System.Windows.Forms.Button();
            this.cmbSearchProjectType = new System.Windows.Forms.ComboBox();
            this.txtSearchProjectt = new System.Windows.Forms.TextBox();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.dataGridProjects = new System.Windows.Forms.DataGridView();
            this.clmProjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProjectView = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmProjectEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearchProject = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Location = new System.Drawing.Point(3, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1314, 636);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dpEmployeeSearchHireDate);
            this.tabPage1.Controls.Add(this.cmbEmployeeSerachPosition);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtSearchEmployeeEgn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lblSearchSurname);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnClearEmployeeSearch);
            this.tabPage1.Controls.Add(this.btnSearchEmployee);
            this.tabPage1.Controls.Add(this.txtEmployeeSerchLastName);
            this.tabPage1.Controls.Add(this.txtSearchEmployeeSurname);
            this.tabPage1.Controls.Add(this.txtSearchEmployeeName);
            this.tabPage1.Controls.Add(this.btnAddEmployee);
            this.tabPage1.Controls.Add(this.dataGridEmployees);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1306, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Служители";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dpEmployeeSearchHireDate
            // 
            this.dpEmployeeSearchHireDate.Checked = false;
            this.dpEmployeeSearchHireDate.Location = new System.Drawing.Point(462, 107);
            this.dpEmployeeSearchHireDate.Name = "dpEmployeeSearchHireDate";
            this.dpEmployeeSearchHireDate.ShowCheckBox = true;
            this.dpEmployeeSearchHireDate.Size = new System.Drawing.Size(223, 27);
            this.dpEmployeeSearchHireDate.TabIndex = 13;
            // 
            // cmbEmployeeSerachPosition
            // 
            this.cmbEmployeeSerachPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeSerachPosition.FormattingEnabled = true;
            this.cmbEmployeeSerachPosition.Location = new System.Drawing.Point(233, 106);
            this.cmbEmployeeSerachPosition.Name = "cmbEmployeeSerachPosition";
            this.cmbEmployeeSerachPosition.Size = new System.Drawing.Size(223, 28);
            this.cmbEmployeeSerachPosition.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Дата на наемане";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Позиция";
            // 
            // txtSearchEmployeeEgn
            // 
            this.txtSearchEmployeeEgn.Location = new System.Drawing.Point(6, 107);
            this.txtSearchEmployeeEgn.Name = "txtSearchEmployeeEgn";
            this.txtSearchEmployeeEgn.Size = new System.Drawing.Size(221, 27);
            this.txtSearchEmployeeEgn.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ЕГН";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // lblSearchSurname
            // 
            this.lblSearchSurname.AutoSize = true;
            this.lblSearchSurname.Location = new System.Drawing.Point(233, 7);
            this.lblSearchSurname.Name = "lblSearchSurname";
            this.lblSearchSurname.Size = new System.Drawing.Size(72, 20);
            this.lblSearchSurname.TabIndex = 6;
            this.lblSearchSurname.Text = "Презиме";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Име";
            // 
            // btnClearEmployeeSearch
            // 
            this.btnClearEmployeeSearch.Location = new System.Drawing.Point(721, 108);
            this.btnClearEmployeeSearch.Name = "btnClearEmployeeSearch";
            this.btnClearEmployeeSearch.Size = new System.Drawing.Size(94, 29);
            this.btnClearEmployeeSearch.TabIndex = 5;
            this.btnClearEmployeeSearch.Text = "Изчисти";
            this.btnClearEmployeeSearch.UseVisualStyleBackColor = true;
            this.btnClearEmployeeSearch.Click += new System.EventHandler(this.btnClearEmployeeSearch_Click);
            // 
            // btnSearchEmployee
            // 
            this.btnSearchEmployee.Location = new System.Drawing.Point(721, 39);
            this.btnSearchEmployee.Name = "btnSearchEmployee";
            this.btnSearchEmployee.Size = new System.Drawing.Size(94, 30);
            this.btnSearchEmployee.TabIndex = 4;
            this.btnSearchEmployee.Text = "Търси";
            this.btnSearchEmployee.UseVisualStyleBackColor = true;
            this.btnSearchEmployee.Click += new System.EventHandler(this.btnSearchEmployee_Click);
            // 
            // txtEmployeeSerchLastName
            // 
            this.txtEmployeeSerchLastName.Location = new System.Drawing.Point(462, 39);
            this.txtEmployeeSerchLastName.Name = "txtEmployeeSerchLastName";
            this.txtEmployeeSerchLastName.Size = new System.Drawing.Size(223, 27);
            this.txtEmployeeSerchLastName.TabIndex = 2;
            // 
            // txtSearchEmployeeSurname
            // 
            this.txtSearchEmployeeSurname.Location = new System.Drawing.Point(233, 39);
            this.txtSearchEmployeeSurname.Name = "txtSearchEmployeeSurname";
            this.txtSearchEmployeeSurname.Size = new System.Drawing.Size(223, 27);
            this.txtSearchEmployeeSurname.TabIndex = 2;
            // 
            // txtSearchEmployeeName
            // 
            this.txtSearchEmployeeName.Location = new System.Drawing.Point(4, 38);
            this.txtSearchEmployeeName.Name = "txtSearchEmployeeName";
            this.txtSearchEmployeeName.Size = new System.Drawing.Size(223, 27);
            this.txtSearchEmployeeName.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(1207, 571);
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
            this.clmHireData,
            this.clmView,
            this.clmEdit,
            this.clmEmployeeTime});
            this.dataGridEmployees.Location = new System.Drawing.Point(3, 170);
            this.dataGridEmployees.Name = "dataGridEmployees";
            this.dataGridEmployees.RowHeadersVisible = false;
            this.dataGridEmployees.RowHeadersWidth = 51;
            this.dataGridEmployees.Size = new System.Drawing.Size(1298, 395);
            this.dataGridEmployees.TabIndex = 0;
            this.dataGridEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEmployees_CellContentClick);
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
            this.clmEgn.DataPropertyName = "Egn";
            this.clmEgn.HeaderText = "ЕГН";
            this.clmEgn.MinimumWidth = 6;
            this.clmEgn.Name = "clmEgn";
            this.clmEgn.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "Name";
            this.clmName.HeaderText = "Име";
            this.clmName.MinimumWidth = 6;
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmSurname
            // 
            this.clmSurname.DataPropertyName = "Surname";
            this.clmSurname.HeaderText = "Презиме";
            this.clmSurname.MinimumWidth = 6;
            this.clmSurname.Name = "clmSurname";
            this.clmSurname.ReadOnly = true;
            // 
            // clmFamilyName
            // 
            this.clmFamilyName.DataPropertyName = "Lastname";
            this.clmFamilyName.HeaderText = "Фамилия";
            this.clmFamilyName.MinimumWidth = 6;
            this.clmFamilyName.Name = "clmFamilyName";
            this.clmFamilyName.ReadOnly = true;
            // 
            // clmPosition
            // 
            this.clmPosition.DataPropertyName = "Position";
            this.clmPosition.HeaderText = "Длъжност";
            this.clmPosition.MinimumWidth = 6;
            this.clmPosition.Name = "clmPosition";
            this.clmPosition.ReadOnly = true;
            // 
            // clmHireData
            // 
            this.clmHireData.DataPropertyName = "HireDate";
            this.clmHireData.HeaderText = "Дата на постъпване";
            this.clmHireData.MinimumWidth = 6;
            this.clmHireData.Name = "clmHireData";
            this.clmHireData.ReadOnly = true;
            // 
            // clmView
            // 
            this.clmView.HeaderText = "";
            this.clmView.MinimumWidth = 6;
            this.clmView.Name = "clmView";
            this.clmView.ReadOnly = true;
            this.clmView.Text = "   преглед   ";
            this.clmView.UseColumnTextForButtonValue = true;
            // 
            // clmEdit
            // 
            this.clmEdit.HeaderText = "";
            this.clmEdit.MinimumWidth = 6;
            this.clmEdit.Name = "clmEdit";
            this.clmEdit.ReadOnly = true;
            this.clmEdit.Text = "  редакция   ";
            this.clmEdit.UseColumnTextForButtonValue = true;
            // 
            // clmEmployeeTime
            // 
            this.clmEmployeeTime.HeaderText = " ";
            this.clmEmployeeTime.MinimumWidth = 6;
            this.clmEmployeeTime.Name = "clmEmployeeTime";
            this.clmEmployeeTime.ReadOnly = true;
            this.clmEmployeeTime.Text = "време";
            this.clmEmployeeTime.UseColumnTextForButtonValue = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClearProjectSearch);
            this.tabPage2.Controls.Add(this.btnSearchProject);
            this.tabPage2.Controls.Add(this.cmbSearchProjectType);
            this.tabPage2.Controls.Add(this.txtSearchProjectt);
            this.tabPage2.Controls.Add(this.btnAddProject);
            this.tabPage2.Controls.Add(this.dataGridProjects);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1306, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Проекти";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearProjectSearch
            // 
            this.btnClearProjectSearch.Location = new System.Drawing.Point(631, 36);
            this.btnClearProjectSearch.Name = "btnClearProjectSearch";
            this.btnClearProjectSearch.Size = new System.Drawing.Size(94, 29);
            this.btnClearProjectSearch.TabIndex = 7;
            this.btnClearProjectSearch.Text = "Изчисти";
            this.btnClearProjectSearch.UseVisualStyleBackColor = true;
            this.btnClearProjectSearch.Click += new System.EventHandler(this.btnClearProjectSearch_Click);
            // 
            // btnSearchProject
            // 
            this.btnSearchProject.Location = new System.Drawing.Point(531, 36);
            this.btnSearchProject.Name = "btnSearchProject";
            this.btnSearchProject.Size = new System.Drawing.Size(94, 30);
            this.btnSearchProject.TabIndex = 6;
            this.btnSearchProject.Text = "Търси";
            this.btnSearchProject.UseVisualStyleBackColor = true;
            this.btnSearchProject.Click += new System.EventHandler(this.btnSearchProject_Click);
            // 
            // cmbSearchProjectType
            // 
            this.cmbSearchProjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchProjectType.FormattingEnabled = true;
            this.cmbSearchProjectType.Location = new System.Drawing.Point(305, 37);
            this.cmbSearchProjectType.Name = "cmbSearchProjectType";
            this.cmbSearchProjectType.Size = new System.Drawing.Size(220, 28);
            this.cmbSearchProjectType.TabIndex = 4;
            // 
            // txtSearchProjectt
            // 
            this.txtSearchProjectt.Location = new System.Drawing.Point(4, 38);
            this.txtSearchProjectt.Name = "txtSearchProjectt";
            this.txtSearchProjectt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchProjectt.Size = new System.Drawing.Size(295, 27);
            this.txtSearchProjectt.TabIndex = 2;
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(1207, 571);
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
            this.clmProjectStatus,
            this.clmProjectView,
            this.clmProjectEdit});
            this.dataGridProjects.Location = new System.Drawing.Point(3, 96);
            this.dataGridProjects.Name = "dataGridProjects";
            this.dataGridProjects.ReadOnly = true;
            this.dataGridProjects.RowHeadersVisible = false;
            this.dataGridProjects.RowHeadersWidth = 51;
            this.dataGridProjects.Size = new System.Drawing.Size(1298, 469);
            this.dataGridProjects.TabIndex = 0;
            this.dataGridProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProjects_CellContentClick);
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
            this.clmProjectname.DataPropertyName = "Name";
            this.clmProjectname.HeaderText = "Име";
            this.clmProjectname.MinimumWidth = 6;
            this.clmProjectname.Name = "clmProjectname";
            this.clmProjectname.ReadOnly = true;
            // 
            // clmProjectStart
            // 
            this.clmProjectStart.DataPropertyName = "Begin";
            this.clmProjectStart.HeaderText = "Начало";
            this.clmProjectStart.MinimumWidth = 6;
            this.clmProjectStart.Name = "clmProjectStart";
            this.clmProjectStart.ReadOnly = true;
            // 
            // clmProjectEnd
            // 
            this.clmProjectEnd.DataPropertyName = "End";
            this.clmProjectEnd.HeaderText = "Край";
            this.clmProjectEnd.MinimumWidth = 6;
            this.clmProjectEnd.Name = "clmProjectEnd";
            this.clmProjectEnd.ReadOnly = true;
            // 
            // clmProjectDescription
            // 
            this.clmProjectDescription.DataPropertyName = "Description";
            this.clmProjectDescription.HeaderText = "Описание";
            this.clmProjectDescription.MinimumWidth = 6;
            this.clmProjectDescription.Name = "clmProjectDescription";
            this.clmProjectDescription.ReadOnly = true;
            // 
            // clmProjectStatus
            // 
            this.clmProjectStatus.DataPropertyName = "FullStatus";
            this.clmProjectStatus.HeaderText = "Статус";
            this.clmProjectStatus.MinimumWidth = 6;
            this.clmProjectStatus.Name = "clmProjectStatus";
            this.clmProjectStatus.ReadOnly = true;
            // 
            // clmProjectView
            // 
            this.clmProjectView.HeaderText = " ";
            this.clmProjectView.MinimumWidth = 6;
            this.clmProjectView.Name = "clmProjectView";
            this.clmProjectView.ReadOnly = true;
            this.clmProjectView.Text = "   преглед    ";
            this.clmProjectView.UseColumnTextForButtonValue = true;
            // 
            // clmProjectEdit
            // 
            this.clmProjectEdit.HeaderText = "";
            this.clmProjectEdit.MinimumWidth = 6;
            this.clmProjectEdit.Name = "clmProjectEdit";
            this.clmProjectEdit.ReadOnly = true;
            this.clmProjectEdit.Text = "   редакция   ";
            this.clmProjectEdit.UseColumnTextForButtonValue = true;
            // 
            // txtSearchProject
            // 
            this.txtSearchProject.Location = new System.Drawing.Point(4, 38);
            this.txtSearchProject.Name = "txtSearchProject";
            this.txtSearchProject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSearchProject.Size = new System.Drawing.Size(295, 27);
            this.txtSearchProject.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 661);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Отчитане на отработено време";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmployees)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridEmployees;
        private System.Windows.Forms.DataGridView dataGridProjects;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnSearchEmployee;
        private System.Windows.Forms.TextBox txtSearchEmployeeName;
        private System.Windows.Forms.Button btnClearEmployeeSearch;
        private System.Windows.Forms.Button btnClearProjectSearch;
        private System.Windows.Forms.Button btnSearchProject;
        private System.Windows.Forms.ComboBox cmbSearchProjectType;
        private System.Windows.Forms.TextBox txtSearchProjectt;
        private System.Windows.Forms.TextBox txtSearchProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectStatus;
        private System.Windows.Forms.DataGridViewButtonColumn clmProjectActions;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEgn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamilyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHireData;
        private System.Windows.Forms.DataGridViewButtonColumn clmView;
        private System.Windows.Forms.DataGridViewButtonColumn clmEdit;
        private System.Windows.Forms.DataGridViewButtonColumn clmEmployeeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProjectStart;
        private System.Windows.Forms.DataGridViewButtonColumn clmProjectView;
        private System.Windows.Forms.DataGridViewButtonColumn clmProjectEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchEmployeeSurname;
        private System.Windows.Forms.Label lblSearchSurname;
        private System.Windows.Forms.TextBox txtEmployeeSerchLastName;
        private System.Windows.Forms.TextBox ee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchEmployeeEgn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpEmployeeSearchHireDate;
        private System.Windows.Forms.ComboBox cmbEmployeeSerachPosition;
        private System.Windows.Forms.Label label5;
    }
}