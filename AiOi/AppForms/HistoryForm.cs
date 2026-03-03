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
    public partial class HistoryForm : Form
    {
        Patients _patient;
        Patients _currentPatient = Program.currentPatient;

        public HistoryForm(Patients patient)
        {
            InitializeComponent();

            _patient = patient;

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            titleLabel.Text += _patient.FullName;
            fullNameLabel.Text = _currentPatient.FullName;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form form = new AuthorizationForm();
            form.Show();
            this.Hide();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            this.medicalSpecialistsTableAdapter.Fill(this.health_Centre_LyamkinDataSet.MedicalSpecialists);
            this.visitsBindingSource.DataSource = Program.context.Visits.Where(p => p.PatientId == _patient.IdPatient).ToList();
        }
    }
}
