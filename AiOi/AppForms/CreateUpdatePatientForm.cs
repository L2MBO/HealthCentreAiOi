using AiOi.Classes;
using AiOi.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace AiOi.AppForms
{
    public partial class CreateUpdatePatientForm : Form
    {
        Patients _patient;
        private string _tempImagePath;

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
            birthdayDateDateTimePicker.MaxDate = DateTime.Today;
            fluorographyDateDateTimePicker.MaxDate = DateTime.Today;
            clinicalExaminationDateDateTimePicker.MaxDate = DateTime.Today;
            disabilityGroupDateDateTimePicker.MaxDate = DateTime.Today;

            EnabledDate();

            if (_patient != null) FillPatientInfo();
        }

        private void FillPatientInfo()
        {
            fullNameTextBox.Text = _patient.FullName;
            userNameTextBox.Text = _patient.UserName;
            passwordTextBox.Text = _patient.Password;
            userRoleIdComboBox.SelectedIndex = (int)(_patient.UserRoleId - 1);
            genderIdComboBox.SelectedIndex = _patient.GenderId - 1;
            birthdayDateDateTimePicker.Value = _patient.BirthdayDate;
            insurancePolicyTextBox.Text = _patient.InsurancePolicy;
            fluorographyDateDateTimePicker.Value = _patient.FluorographyDate;
            if (_patient.ClinicalExaminationDate.HasValue)
                clinicalExaminationDateDateTimePicker.Value = (DateTime)_patient.ClinicalExaminationDate;
            heightNumericUpDown.Value = _patient.Height;
            weightNumericUpDown.Value = _patient.Weight;
            ImageHelper.LoadImage(_patient, avatarPictureBox);
            disabilityGroupComboBox.SelectedIndex = SetDisabilityGroup();
            SetDisabilityGroupDate();
        }

        private void SaveChangesLogic()
        {
            if (ValidationManager.ValidationHelper(fullNameTextBox.Text, userNameTextBox.Text, passwordTextBox.Text, insurancePolicyTextBox.Text)) return;

            if (MessageBox.Show("Сохранить изменения?", "Подтвердите действие", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            if (_patient == null)
            {
                _patient = new Patients();
                Program.context.Patients.Add(_patient);
            }

            try
            {
                SaveChanges();
                MessageHelper.ShowInfoMessage("Изменения сохранены!");
                backButton_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage("Не удалось сохранить зменения: " + ex.Message);
            }
        }

        private void SaveChanges()
        {
            _patient.FullName = fullNameTextBox.Text;
            _patient.UserName = userNameTextBox.Text;
            _patient.Password = passwordTextBox.Text;
            _patient.UserRoleId = userRoleIdComboBox.SelectedIndex + 1;
            _patient.GenderId = genderIdComboBox.SelectedIndex + 1;
            _patient.BirthdayDate = birthdayDateDateTimePicker.Value;
            _patient.InsurancePolicy = insurancePolicyTextBox.Text;
            _patient.FluorographyDate = fluorographyDateDateTimePicker.Value;
            _patient.ClinicalExaminationDate = clinicalExaminationDateDateTimePicker.Value;
            _patient.Height = (int)heightNumericUpDown.Value;
            _patient.Weight = (int)weightNumericUpDown.Value;

            _patient.DisabilityGroup1 = null;
            _patient.DisabilityGroup2 = null;
            _patient.DisabilityGroup3 = null;
            _patient.DisabilityGroup1Date = null;
            _patient.DisabilityGroup2Date = null;
            _patient.DisabilityGroup3Date = null;

            switch (disabilityGroupComboBox.SelectedIndex)
            {
                case 1:
                    _patient.DisabilityGroup1 = 1;
                    _patient.DisabilityGroup1Date = disabilityGroupDateDateTimePicker.Value;
                    break;
                case 2:
                    _patient.DisabilityGroup2 = 1;
                    _patient.DisabilityGroup2Date = disabilityGroupDateDateTimePicker.Value;
                    break;
                case 3:
                    _patient.DisabilityGroup3 = 1;
                    _patient.DisabilityGroup3Date = disabilityGroupDateDateTimePicker.Value;
                    break;
            }

            if (!string.IsNullOrEmpty(_tempImagePath))
            {
                _patient.ImagePatch = _tempImagePath;
            }

            Program.context.SaveChanges();
        }

        private int SetDisabilityGroup()
        {
            if (_patient.DisabilityGroup1 == 1)
                return 1;
            else if (_patient.DisabilityGroup2 == 1)
                return 2;
            else if (_patient.DisabilityGroup3 == 1)
                return 3;
            return 0;
        }

        private void SetDisabilityGroupDate()
        {
            DateTime dateToSet = DateTime.Today;

            switch (disabilityGroupComboBox.SelectedIndex)
            {
                case 1:
                    if (_patient.DisabilityGroup1Date.HasValue)
                        dateToSet = _patient.DisabilityGroup1Date.Value;
                    break;
                case 2:
                    if (_patient.DisabilityGroup2Date.HasValue)
                        dateToSet = _patient.DisabilityGroup2Date.Value;
                    break;
                case 3:
                    if (_patient.DisabilityGroup3Date.HasValue)
                        dateToSet = _patient.DisabilityGroup3Date.Value;
                    break;
                default:
                    break;
            }

            disabilityGroupDateDateTimePicker.Value = dateToSet;
        }

        private void EnabledDate()
        {
            if (disabilityGroupComboBox.SelectedIndex != 0)
                disabilityGroupDateDateTimePicker.Enabled = true;

            else
                disabilityGroupDateDateTimePicker.Enabled = false;
        }

        /// <summary>
        /// Метод для выбора и сохранения нового изображения
        /// </summary>
        private void ChoeseImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Выберите фотографию пациента";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string imagesFolder = Path.Combine(Application.StartupPath, "Images");

                        if (!Directory.Exists(imagesFolder))
                            Directory.CreateDirectory(imagesFolder);

                        string fileName = Path.GetFileName(openFileDialog.FileName);
                        string newFilePath = Path.Combine(imagesFolder, fileName);

                        // Логика удаления СТАРОГО фото
                        if (_patient != null && !string.IsNullOrEmpty(_patient.ImagePatch))
                        {
                            if (_patient.ImagePatch != fileName)
                            {
                                string oldFilePath = Path.Combine(imagesFolder, _patient.ImagePatch);
                                if (File.Exists(oldFilePath))
                                {
                                    try { File.Delete(oldFilePath); } catch { }
                                }
                            }
                        }

                        // Загружаем, ресайзим и сохраняем
                        using (Image originalImage = Image.FromFile(openFileDialog.FileName))
                        {
                            using (Bitmap resizedImage = ResizeImage(originalImage, 300, 200))
                            {
                                resizedImage.Save(newFilePath);
                            }
                        }

                        // Показываем изображение
                        System.Threading.Thread.Sleep(50);
                        if (File.Exists(newFilePath))
                        {
                            if (avatarPictureBox.Image != null)
                            {
                                avatarPictureBox.Image.Dispose();
                                avatarPictureBox.Image = null;
                            }
                            avatarPictureBox.Image = new Bitmap(newFilePath);
                            avatarPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        }

                        _tempImagePath = fileName;
                    }
                    catch (Exception ex)
                    {
                        MessageHelper.ShowErrorMessage($"Не удалось загрузить изображение: {ex.Message}");
                    }
                }
            }
        }

        // Метод для изменения размера изображения с сохранением пропорций (вписывание в рамку 300x200)
        private Bitmap ResizeImage(Image image, int maxWidth, int maxHeight)
        {
            int width = image.Width;
            int height = image.Height;

            // Вычисляем коэффициенты масштабирования
            double ratioX = (double)maxWidth / width;
            double ratioY = (double)maxHeight / height;
            double ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(width * ratio);
            int newHeight = (int)(height * ratio);

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }

        private void avatarPictureBox_Click(object sender, EventArgs e)
        {
            ChoeseImage();
        }

        private void disabilityGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnabledDate();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            SaveChangesLogic();
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