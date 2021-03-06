﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TimeTable.Data.Models;
using TimeTable.Services;

namespace TimeTable.UI
{
    public partial class AddProject : Form
    {
        private ProjectService _projectService;
        public AddProject()
        {
            InitializeComponent();
            _projectService = new ProjectService();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateProject())
            {
                Project project = new Project();
                project.Name = txtProjectName.Text;
                project.Description = txtProjectDescription.Text;
                project.Begin = dpStart.Value;
                project.End = dpEnd.Value;
                project.MaxHours = npMaxHours.Value;
                project.Status = "O";
                _projectService.Add(project);
                this.DialogResult = DialogResult.OK;
                Close();
            }
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
    }
}
