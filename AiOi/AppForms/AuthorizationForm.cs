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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Program.currentPatient = Program.context.Patients.FirstOrDefault(u => u.UserName == userNameTextBox.Text 
                && u.Password == passwordTextBox.Text);

            if (Program.currentPatient != null )
            {
                Form form = new MainForm();
                form.Show();
                this.Hide();
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }
    }
}
