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

        public HistoryForm(Patients patient)
        {
            InitializeComponent();

            _patient = patient;
        }

        private void HistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
