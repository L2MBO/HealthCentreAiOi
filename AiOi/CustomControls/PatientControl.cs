using AiOi.AppForms;
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

namespace AiOi.CustomControls
{
    public partial class PatientControl : UserControl
    {
        Patients _patient;

        public PatientControl(Patients patient)
        {
            InitializeComponent();

            _patient = patient;

            FillPatientData();
        }

        private void FillPatientData()
        {
            
        }

        private void PatientControl_Load(object sender, EventArgs e)
        {
            Form form = new CreateUpdatePatientForm(_patient);
            form.Show();
            this.ParentForm.Hide();
        }
    }
}
