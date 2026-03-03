using AiOi.Classes;
using System;
using System.Linq;
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

            if (Program.currentPatient != null)
            {
                Form form = new MainForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageHelper.ShowInfoMessage("Неверный логин и/или пароль");
            }
        }

        private void guestButton_Click(object sender, EventArgs e)
        {
            Program.currentPatient = null;
            Form form = new MainForm();
            form.Show();
            this.Hide();
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
