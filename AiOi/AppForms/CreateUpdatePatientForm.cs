using AiOi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiOi.AppForms
{
    public partial class CreateUpdatePatientForm : Form
    {
        Patients _patient;

        public CreateUpdatePatientForm(Patients patient = null)
        {
            InitializeComponent();

            _patient = patient;

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            titleLabel.Text = _patient == null ? "Добавление пациента" : "Редактирование пациента";
            userRoleIdComboBox.SelectedIndex = 0;
            genderIdComboBox.SelectedIndex = 0;
            disabilityGroupComboBox.SelectedIndex = 0;

            EnabledDate();

            if (_patient != null) FillPatientInfo();
        }

        private void FillPatientInfo()
        {

        }

        private void CreateOrUpdateLogic()
        {
            
        }

        private void EnabledDate()
        {
            if (disabilityGroupComboBox.SelectedIndex != 0)
            {
                disabilityGroupDateDateTimePicker.Enabled = true;
            }
        }

        private void disabilityGroup1ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledDate();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            CreateOrUpdateLogic();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void CreateUpdatePatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
