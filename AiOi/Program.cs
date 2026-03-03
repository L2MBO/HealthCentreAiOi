using AiOi.AppForms;
using AiOi.Classes;
using AiOi.Models;
using System;
using System.Windows.Forms;

namespace AiOi
{
    internal static class Program
    {
        public static readonly AiOiModel context = new AiOiModel();
        public static Patients currentPatient;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!context.Database.Exists())
            {
                MessageHelper.ShowErrorMessage("Не удалось подключиться к базе данных!");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }
    }
}
