using AiOi.AppForms;
using AiOi.Classes;
using AiOi.Models;
using System;
using System.Windows.Forms;

namespace AiOi.CustomControls
{
    public partial class PatientControl : UserControl
    {
        Patients _patient;
        Patients _currentPatient = Program.currentPatient;

        public PatientControl(Patients patient)
        {
            InitializeComponent();

            _patient = patient;

            FillPatientData();
        }

        private void FillPatientData()
        {
            string[] parts = _patient.FullName.Split(' ');

            lastNameLabel.Text += parts.Length > 0 ? parts[0].Trim() : "";
            nameLabel.Text += parts.Length > 1 ? parts[1].Trim() : "";
            patronymicLabel.Text += parts.Length > 2 ? parts[2].Trim() : "";
            genderLabel.Text += _patient.Gender.Name;
            insurancePolicyLabel.Text += _patient.InsurancePolicy;

            ImageHelper.LoadImage(_patient, avatarPictureBox);

            LoadPatientStatus();
            AddUserFunctional();
        }

        private void AddUserFunctional()
        {
            historyButton.Visible = _currentPatient != null && _currentPatient.UserRoleId != 1;
        }

        private void LoadPatientStatus()
        {
            if (_patient.ClinicalExaminationDate != null)
                dispanserPictureBox.Image = Properties.Resources.dispanser;

            if (_patient.DisabilityGroup1 == 1 || _patient.DisabilityGroup2 == 1 || _patient.DisabilityGroup3 == 1)
                handicapedPictureBox.Image = Properties.Resources.handicaped;

            if (_patient.FluorographyDate != null)
                fluorographyPictureBox.Image = Properties.Resources.fluorography;
        }

        private void PatientControl_Click(object sender, EventArgs e)
        {
            if (_currentPatient != null && _currentPatient.UserRoleId == 3)
            {
                Form form = new CreateUpdatePatientForm(_patient);
                form.Show();
                this.ParentForm.Hide();
            }
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            Form form = new HistoryForm(_patient);
            form.ShowDialog();
        }
    }
}
