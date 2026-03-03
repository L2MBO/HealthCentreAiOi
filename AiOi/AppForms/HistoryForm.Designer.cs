namespace AiOi.AppForms
{
    partial class HistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.logoutButton = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.health_Centre_LyamkinDataSet = new AiOi.Health_Centre_LyamkinDataSet();
            this.visitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitsTableAdapter = new AiOi.Health_Centre_LyamkinDataSetTableAdapters.VisitsTableAdapter();
            this.visitsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicalSpecialistsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalSpecialistsTableAdapter = new AiOi.Health_Centre_LyamkinDataSetTableAdapters.MedicalSpecialistsTableAdapter();
            this.visitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalSpecialistIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health_Centre_LyamkinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalSpecialistsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.logoutButton);
            this.splitContainer1.Panel1.Controls.Add(this.fullNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.titleLabel);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.TabIndex = 1;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Red;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoutButton.Location = new System.Drawing.Point(657, 56);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(132, 27);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Выйти из системы";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(419, 9);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fullNameLabel.Size = new System.Drawing.Size(373, 13);
            this.fullNameLabel.TabIndex = 7;
            this.fullNameLabel.Text = "ФИО";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(100, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(183, 21);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "ИСТОРИЯ ПАЦИЕНТА:\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitDateDataGridViewTextBoxColumn,
            this.medicalSpecialistIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.visitsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // health_Centre_LyamkinDataSet
            // 
            this.health_Centre_LyamkinDataSet.DataSetName = "Health_Centre_LyamkinDataSet";
            this.health_Centre_LyamkinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitsBindingSource
            // 
            this.visitsBindingSource.DataMember = "Visits";
            this.visitsBindingSource.DataSource = this.health_Centre_LyamkinDataSet;
            // 
            // visitsTableAdapter
            // 
            this.visitsTableAdapter.ClearBeforeFill = true;
            // 
            // visitsBindingSource1
            // 
            this.visitsBindingSource1.DataMember = "Visits";
            this.visitsBindingSource1.DataSource = this.health_Centre_LyamkinDataSet;
            // 
            // medicalSpecialistsBindingSource
            // 
            this.medicalSpecialistsBindingSource.DataMember = "MedicalSpecialists";
            this.medicalSpecialistsBindingSource.DataSource = this.health_Centre_LyamkinDataSet;
            // 
            // medicalSpecialistsTableAdapter
            // 
            this.medicalSpecialistsTableAdapter.ClearBeforeFill = true;
            // 
            // visitDateDataGridViewTextBoxColumn
            // 
            this.visitDateDataGridViewTextBoxColumn.DataPropertyName = "VisitDate";
            this.visitDateDataGridViewTextBoxColumn.HeaderText = "VisitDate";
            this.visitDateDataGridViewTextBoxColumn.Name = "visitDateDataGridViewTextBoxColumn";
            this.visitDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medicalSpecialistIdDataGridViewTextBoxColumn
            // 
            this.medicalSpecialistIdDataGridViewTextBoxColumn.DataPropertyName = "MedicalSpecialistId";
            this.medicalSpecialistIdDataGridViewTextBoxColumn.DataSource = this.medicalSpecialistsBindingSource;
            this.medicalSpecialistIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.medicalSpecialistIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.medicalSpecialistIdDataGridViewTextBoxColumn.HeaderText = "MedicalSpecialistId";
            this.medicalSpecialistIdDataGridViewTextBoxColumn.Name = "medicalSpecialistIdDataGridViewTextBoxColumn";
            this.medicalSpecialistIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.medicalSpecialistIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.medicalSpecialistIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.medicalSpecialistIdDataGridViewTextBoxColumn.ValueMember = "IdMedicalSpecialist";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryForm";
            this.Text = "История пациента";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health_Centre_LyamkinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalSpecialistsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Health_Centre_LyamkinDataSet health_Centre_LyamkinDataSet;
        private System.Windows.Forms.BindingSource visitsBindingSource;
        private Health_Centre_LyamkinDataSetTableAdapters.VisitsTableAdapter visitsTableAdapter;
        private System.Windows.Forms.BindingSource visitsBindingSource1;
        private System.Windows.Forms.BindingSource medicalSpecialistsBindingSource;
        private Health_Centre_LyamkinDataSetTableAdapters.MedicalSpecialistsTableAdapter medicalSpecialistsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn medicalSpecialistIdDataGridViewTextBoxColumn;
    }
}