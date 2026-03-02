using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiOi.Classes
{
    internal class MessageHelper
    {
        public static void ShowErrorMessage(string text)
        {
            MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfoMessage(string text)
        {
            MessageBox.Show(text, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
