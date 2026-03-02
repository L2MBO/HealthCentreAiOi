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
            
        }
    }
}
