using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TimeTable.Data.Models;
using TimeTable.Services;

namespace TimeTable.UI
{
    public partial class ViewEditProject : Form
    {
        private Project _project;
        private ProjectService _projectService;
        private ProjectMonthService _projectMonthService;
        private List<ProjectMonths> _projectMonths;

        public ViewEditProject(Project project)
        {
            InitializeComponent();
            _projectService = new ProjectService();
            _projectMonthService = new ProjectMonthService();
            cmbStatus.Items.AddRange(new string[] { "Неприключен", "Приключен" });
            cmbStatus.Text = "Неприключен";
            gridViewProjectMonths.AutoGenerateColumns = false;

            _project = project;
            txtProjectName.Text = project.ProjectName;
            txtProjectDescription.Text = project.ProjectDescription;
            dpStart.Value = project.ProjectBegin;
            dpEnd.Value = project.ProjectEnd;
            npMaxHours.Value = (decimal) project.ProjectMaxhours;

            if (project.ProjectStatus == "C")
            {
                txtProjectName.ReadOnly = true;
                txtProjectName.Enabled = false;
                txtProjectDescription.ReadOnly = true;
                txtProjectDescription.Enabled = false;
                dpStart.Enabled = false;
                dpEnd.Enabled = false;
                npMaxHours.ReadOnly = true;
                npMaxHours.Enabled = false;
                cmbStatus.Text = "Приключен";
                cmbStatus.Enabled = false;
                btnSave.Enabled = false;
            }

            ReloadProjectMonths();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateProject())
            {
                _project.ProjectName = txtProjectName.Text;
                _project.ProjectDescription = txtProjectDescription.Text;
                _project.ProjectBegin = dpStart.Value;
                _project.ProjectEnd = dpEnd.Value;
                _project.ProjectMaxhours = npMaxHours.Value;
                if ((cmbStatus.Text == "Приключен" &&
                    MessageBox.Show("Сигурни ли сте, че искате да приключите този проект? Действието е необратимо!", "Потвърждение", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    || cmbStatus.Text == "Неприключен")
                {
                    _project.ProjectStatus = cmbStatus.Text == "Неприключен" ? "O" : "C";
                    _projectService.Update(_project);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void ReloadProjectMonths()
        {
            _projectMonths = _projectService.GetProjectMonths(_project.ProjectId);
            gridViewProjectMonths.DataSource = _projectMonths;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateProject()
        {
            bool result = true;
            if (string.IsNullOrEmpty(txtProjectName.Text))
            {
                Helpers.ShowError("Полето Име е задължително");
                result = false;
            }
            else if (string.IsNullOrEmpty(txtProjectDescription.Text))
            {
                Helpers.ShowError("Полето Описание е задължително");
                result = false;
            }
            else if (npMaxHours.Value <= 0)
            {
                Helpers.ShowError("Максималният брой часове трябва да е положителен");
                result = false;
            }

            return result;
        }

        private void gridViewProjectMonths_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewProjectMonths.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                ProjectMonths pm = _projectMonths[e.RowIndex];
                if (pm.ProjectMonthStatus == "C")
                {
                    MessageBox.Show("Отчетният месец вече е приключен!");
                }
                else
                {
                    pm.ProjectMonthStatus = "C";
                    _projectMonthService.Update(pm);
                    ReloadProjectMonths();
                }
            }
        }
    }
}
