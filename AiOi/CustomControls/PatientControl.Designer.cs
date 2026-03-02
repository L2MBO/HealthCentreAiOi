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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dispanserPictureBox = new System.Windows.Forms.PictureBox();
            this.fluorographyPictureBox = new System.Windows.Forms.PictureBox();
            this.handicapedPictureBox = new System.Windows.Forms.PictureBox();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dispanserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluorographyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handicapedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(13, 12);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(398, 21);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Фамилия: ";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(13, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(398, 21);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Имя: ";
            // 
            // patronymicLabel
            // 
            this.patronymicLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicLabel.Location = new System.Drawing.Point(13, 62);
            this.patronymicLabel.Name = "patronymicLabel";
            this.patronymicLabel.Size = new System.Drawing.Size(398, 21);
            this.patronymicLabel.TabIndex = 4;
            this.patronymicLabel.Text = "Отчество: ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пол: ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Страховой полис: ";
            // 
            // dispanserPictureBox
            // 
            this.dispanserPictureBox.Location = new System.Drawing.Point(429, 12);
            this.dispanserPictureBox.Name = "dispanserPictureBox";
            this.dispanserPictureBox.Size = new System.Drawing.Size(60, 60);
            this.dispanserPictureBox.TabIndex = 7;
            this.dispanserPictureBox.TabStop = false;
            // 
            // fluorographyPictureBox
            // 
            this.fluorographyPictureBox.Location = new System.Drawing.Point(429, 77);
            this.fluorographyPictureBox.Name = "fluorographyPictureBox";
            this.fluorographyPictureBox.Size = new System.Drawing.Size(60, 60);
            this.fluorographyPictureBox.TabIndex = 8;
            this.fluorographyPictureBox.TabStop = false;
            // 
            // handicapedPictureBox
            // 
            this.handicapedPictureBox.Location = new System.Drawing.Point(494, 12);
            this.handicapedPictureBox.Name = "handicapedPictureBox";
            this.handicapedPictureBox.Size = new System.Drawing.Size(60, 60);
            this.handicapedPictureBox.TabIndex = 9;
            this.handicapedPictureBox.TabStop = false;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Location = new System.Drawing.Point(568, 12);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(179, 125);
            this.avatarPictureBox.TabIndex = 10;
            this.avatarPictureBox.TabStop = false;
            // 
            // PatientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.avatarPictureBox);
            this.Controls.Add(this.handicapedPictureBox);
            this.Controls.Add(this.fluorographyPictureBox);
            this.Controls.Add(this.dispanserPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.patronymicLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Name = "PatientControl";
            this.Size = new System.Drawing.Size(760, 148);
            this.Load += new System.EventHandler(this.PatientControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dispanserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluorographyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handicapedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label patronymicLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox dispanserPictureBox;
        private System.Windows.Forms.PictureBox fluorographyPictureBox;
        private System.Windows.Forms.PictureBox handicapedPictureBox;
        private System.Windows.Forms.PictureBox avatarPictureBox;
    }
}
