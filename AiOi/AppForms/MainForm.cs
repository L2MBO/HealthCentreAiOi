using AiOi.CustomControls;
using AiOi.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AiOi.AppForms
{
    public partial class MainForm : Form
    {
        Patients _currentPatient = Program.currentPatient;

        public MainForm()
        {
            InitializeComponent();
            SetFormStyle();
        }

        private void SetFormStyle()
        {
            sortComboBox.SelectedIndex = 0;
            filterComboBox.SelectedIndex = 0;

            AddUserFunctional();
            ApplyFilterAndSort();
        }

        private void AddUserFunctional()
        {
            if (_currentPatient != null)
            {
                fullNameLabel.Visible = true;
                fullNameLabel.Text = _currentPatient.FullName;

                if (_currentPatient.UserRoleId != 1)
                {
                    searchLabel.Visible = true;
                    searchTextBox.Visible = true;
                    sortLabel.Visible = true;
                    sortComboBox.Visible = true;
                    filterLabel.Visible = true;
                    filterComboBox.Visible = true;

                    addPatientButton.Visible = _currentPatient.UserRoleId == 3;
                }
            }
            else
            {
                fullNameLabel.Visible = false;
                searchLabel.Visible = false;
                searchTextBox.Visible = false;
                sortLabel.Visible = false;
                sortComboBox.Visible = false;
                filterLabel.Visible = false;
                filterComboBox.Visible = false;
                addPatientButton.Visible = false;
            }
        }

        private void ApplyFilterAndSort()
        {
            flowLayoutPanel.Controls.Clear();

            IQueryable<Patients> patients = Program.context.Patients.OrderBy(a => a.BirthdayDate);

            if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                string searchText = searchTextBox.Text.ToLower();

                patients = patients.Where(p => p.FullName.ToLower().Contains(searchText)
                    || p.InsurancePolicy.ToLower().Contains(searchText));
            }

            if (sortComboBox.SelectedIndex == 1)
            {
                patients = patients.OrderByDescending(a => a.BirthdayDate);
            }

            switch (filterComboBox.SelectedIndex)
            {
                case 1:
                    patients = patients.Where(g => g.GenderId == 1);
                    break;

                case 2:
                    patients = patients.Where(g => g.GenderId == 2);
                    break;
            }

            foreach (Patients patient in patients.ToList())
            {
                PatientControl patientControl = new PatientControl(patient);
                patientControl.Margin = new Padding(10);
                flowLayoutPanel.Controls.Add(patientControl);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilterAndSort();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            Form form = new CreateUpdatePatientForm();
            form.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form form = new AuthorizationForm();
            form.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
