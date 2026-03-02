namespace AiOi.CustomControls
{
    partial class PatientControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.patronymicLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.insurancePolicyLabel = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Button();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.handicapedPictureBox = new System.Windows.Forms.PictureBox();
            this.fluorographyPictureBox = new System.Windows.Forms.PictureBox();
            this.dispanserPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handicapedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluorographyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispanserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(13, 12);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(398, 21);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Фамилия: ";
            this.lastNameLabel.Click += new System.EventHandler(this.PatientControl_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(13, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(398, 21);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Имя: ";
            this.nameLabel.Click += new System.EventHandler(this.PatientControl_Click);
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patronymicLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicLabel.Location = new System.Drawing.Point(13, 62);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(398, 21);
            this.patronymicLabel.TabIndex = 4;
            this.patronymicLabel.Text = "Отчество: ";
            this.patronymicLabel.Click += new System.EventHandler(this.PatientControl_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderLabel.Location = new System.Drawing.Point(13, 90);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(398, 21);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Пол: ";
            this.genderLabel.Click += new System.EventHandler(this.PatientControl_Click);
            // 
            // insurancePolicyLabel
            // 
            this.insurancePolicyLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insurancePolicyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insurancePolicyLabel.Location = new System.Drawing.Point(13, 117);
            this.insurancePolicyLabel.Name = "insurancePolicyLabel";
            this.insurancePolicyLabel.Size = new System.Drawing.Size(398, 21);
            this.insurancePolicyLabel.TabIndex = 6;
            this.insurancePolicyLabel.Text = "Страховой полис: ";
            this.insurancePolicyLabel.Click += new System.EventHandler(this.PatientControl_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.Color.Red;
            this.historyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyButton.Location = new System.Drawing.Point(681, 117);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(69, 27);
            this.historyButton.TabIndex = 11;
            this.historyButton.Text = "История";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarPictureBox.Location = new System.Drawing.Point(650, 12);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(100, 100);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPictureBox.TabIndex = 10;
            this.avatarPictureBox.TabStop = false;
            this.avatarPictureBox.Click += new System.EventHandler(this.PatientControl_Click);
            // 
            // handicapedPictureBox
            // 
            this.handicapedPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.handicapedPictureBox.Location = new System.Drawing.Point(551, 12);
            this.handicapedPictureBox.Name = "handicapedPictureBox";
            this.handicapedPictureBox.Size = new System.Drawing.Size(60, 60);
            this.handicapedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handicapedPictureBox.TabIndex = 9;
            this.handicapedPictureBox.TabStop = false;
            this.handicapedPictureBox.Click += new System.EventHandler(this.PatientControl_Click);
            // 
            // fluorographyPictureBox
            // 
            this.fluorographyPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fluorographyPictureBox.Location = new System.Drawing.Point(486, 77);
            this.fluorographyPictureBox.Name = "fluorographyPictureBox";
            this.fluorographyPictureBox.Size = new System.Drawing.Size(60, 60);
            this.fluorographyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fluorographyPictureBox.TabIndex = 8;
            this.fluorographyPictureBox.TabStop = false;
            this.fluorographyPictureBox.Click += new System.EventHandler(this.PatientControl_Click);
            // 
            // dispanserPictureBox
            // 
            this.dispanserPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dispanserPictureBox.Location = new System.Drawing.Point(486, 12);
            this.dispanserPictureBox.Name = "dispanserPictureBox";
            this.dispanserPictureBox.Size = new System.Drawing.Size(60, 60);
            this.dispanserPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dispanserPictureBox.TabIndex = 7;
            this.dispanserPictureBox.TabStop = false;
            this.dispanserPictureBox.Click += new System.EventHandler(this.PatientControl_Click);
            // 
            // PatientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.avatarPictureBox);
            this.Controls.Add(this.handicapedPictureBox);
            this.Controls.Add(this.fluorographyPictureBox);
            this.Controls.Add(this.dispanserPictureBox);
            this.Controls.Add(this.insurancePolicyLabel);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "PatientControl";
            this.Size = new System.Drawing.Size(760, 148);
            this.Click += new System.EventHandler(this.PatientControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handicapedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluorographyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dispanserPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label insurancePolicyLabel;
        private System.Windows.Forms.PictureBox dispanserPictureBox;
        private System.Windows.Forms.PictureBox fluorographyPictureBox;
        private System.Windows.Forms.PictureBox handicapedPictureBox;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Button historyButton;
    }
}
