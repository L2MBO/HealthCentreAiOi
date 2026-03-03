using AiOi.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AiOi.Classes
{
    internal class ImageHelper
    {
        public static void LoadImage(Patients patient, PictureBox pictureBox)
        {
            if (patient == null || string.IsNullOrWhiteSpace(patient.ImagePatch))
            {
                pictureBox.Image = Properties.Resources.photo;
                return;
            }

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string imagePath = Path.Combine(baseDirectory, "Images", patient.ImagePatch);

            if (!File.Exists(imagePath))
            {
                pictureBox.Image = Properties.Resources.photo;
                return;
            }

            try
            {
                using (Image img = Image.FromFile(imagePath))
                {
                    pictureBox.Image = new Bitmap(img);
                }
            }
            catch (Exception)
            {
                pictureBox.Image = Properties.Resources.photo;
            }
        }
    }
}
