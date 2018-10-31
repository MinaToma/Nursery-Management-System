namespace Nursery_Management_System
{
    partial class Child
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Child));
            this.backButton = new System.Windows.Forms.Button();
            this.childProfilePanel = new System.Windows.Forms.Panel();
            this.genderPanel = new System.Windows.Forms.Panel();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.childImageButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.importImageButton = new System.Windows.Forms.Button();
            this.detailsOfTheDayLabel = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.DOBpicker = new System.Windows.Forms.DateTimePicker();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.childNameLabel = new System.Windows.Forms.Label();
            this.groupedFeatures = new System.Windows.Forms.GroupBox();
            this.feature9 = new System.Windows.Forms.CheckBox();
            this.feature8 = new System.Windows.Forms.CheckBox();
            this.feature7 = new System.Windows.Forms.CheckBox();
            this.feature6 = new System.Windows.Forms.CheckBox();
            this.feature5 = new System.Windows.Forms.CheckBox();
            this.feature4 = new System.Windows.Forms.CheckBox();
            this.feature3 = new System.Windows.Forms.CheckBox();
            this.feature2 = new System.Windows.Forms.CheckBox();
            this.feature1 = new System.Windows.Forms.CheckBox();
            this.childName = new System.Windows.Forms.TextBox();
            this.childDOBLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.childProfilePanel.SuspendLayout();
            this.genderPanel.SuspendLayout();
            this.groupedFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 90);
            this.backButton.TabIndex = 18;
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // childProfilePanel
            // 
            this.childProfilePanel.Controls.Add(this.genderPanel);
            this.childProfilePanel.Controls.Add(this.childImageButton);
            this.childProfilePanel.Controls.Add(this.saveButton);
            this.childProfilePanel.Controls.Add(this.importImageButton);
            this.childProfilePanel.Controls.Add(this.detailsOfTheDayLabel);
            this.childProfilePanel.Controls.Add(this.note);
            this.childProfilePanel.Controls.Add(this.DOBpicker);
            this.childProfilePanel.Controls.Add(this.roomNumberLabel);
            this.childProfilePanel.Controls.Add(this.roomNumber);
            this.childProfilePanel.Controls.Add(this.childNameLabel);
            this.childProfilePanel.Controls.Add(this.groupedFeatures);
            this.childProfilePanel.Controls.Add(this.childName);
            this.childProfilePanel.Controls.Add(this.childDOBLabel);
            this.childProfilePanel.Controls.Add(this.genderLabel);
            this.childProfilePanel.Enabled = false;
            this.childProfilePanel.Location = new System.Drawing.Point(0, 0);
            this.childProfilePanel.Name = "childProfilePanel";
            this.childProfilePanel.Size = new System.Drawing.Size(920, 540);
            this.childProfilePanel.TabIndex = 29;
            this.childProfilePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.childProfilePanel_Paint);
            // 
            // genderPanel
            // 
            this.genderPanel.Controls.Add(this.male);
            this.genderPanel.Controls.Add(this.female);
            this.genderPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genderPanel.Location = new System.Drawing.Point(303, 90);
            this.genderPanel.Name = "genderPanel";
            this.genderPanel.Size = new System.Drawing.Size(280, 82);
            this.genderPanel.TabIndex = 29;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.male.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.male.Image = ((System.Drawing.Image)(resources.GetObject("male.Image")));
            this.male.Location = new System.Drawing.Point(157, 20);
            this.male.Name = "male";
            this.male.Padding = new System.Windows.Forms.Padding(3);
            this.male.Size = new System.Drawing.Size(111, 40);
            this.male.TabIndex = 1;
            this.male.Text = "Male";
            this.male.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Checked = true;
            this.female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.female.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.female.Image = ((System.Drawing.Image)(resources.GetObject("female.Image")));
            this.female.Location = new System.Drawing.Point(7, 20);
            this.female.Name = "female";
            this.female.Padding = new System.Windows.Forms.Padding(3);
            this.female.Size = new System.Drawing.Size(129, 40);
            this.female.TabIndex = 2;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // childImageButton
            // 
            this.childImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childImageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.childImageButton.FlatAppearance.BorderSize = 0;
            this.childImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.childImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.childImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.childImageButton.Image = ((System.Drawing.Image)(resources.GetObject("childImageButton.Image")));
            this.childImageButton.Location = new System.Drawing.Point(639, 25);
            this.childImageButton.Name = "childImageButton";
            this.childImageButton.Size = new System.Drawing.Size(248, 256);
            this.childImageButton.TabIndex = 5;
            this.childImageButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.Location = new System.Drawing.Point(639, 472);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(248, 44);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // importImageButton
            // 
            this.importImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importImageButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.importImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.importImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.importImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importImageButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.importImageButton.ForeColor = System.Drawing.Color.DimGray;
            this.importImageButton.Location = new System.Drawing.Point(639, 316);
            this.importImageButton.Name = "importImageButton";
            this.importImageButton.Size = new System.Drawing.Size(248, 44);
            this.importImageButton.TabIndex = 6;
            this.importImageButton.Text = "Import Image";
            this.importImageButton.UseVisualStyleBackColor = true;
            this.importImageButton.Visible = false;
            // 
            // detailsOfTheDayLabel
            // 
            this.detailsOfTheDayLabel.AutoSize = true;
            this.detailsOfTheDayLabel.Font = new System.Drawing.Font("Alpha Romanie G98", 10F);
            this.detailsOfTheDayLabel.ForeColor = System.Drawing.Color.DimGray;
            this.detailsOfTheDayLabel.Location = new System.Drawing.Point(636, 284);
            this.detailsOfTheDayLabel.Name = "detailsOfTheDayLabel";
            this.detailsOfTheDayLabel.Size = new System.Drawing.Size(261, 18);
            this.detailsOfTheDayLabel.TabIndex = 24;
            this.detailsOfTheDayLabel.Text = "*click the image for details of the day.";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Font = new System.Drawing.Font("Alpha Romanie G98", 10F);
            this.note.ForeColor = System.Drawing.Color.DimGray;
            this.note.Location = new System.Drawing.Point(636, 284);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(261, 18);
            this.note.TabIndex = 25;
            this.note.Text = "*click the image for details of the day.";
            // 
            // DOBpicker
            // 
            this.DOBpicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DOBpicker.Location = new System.Drawing.Point(303, 190);
            this.DOBpicker.Name = "DOBpicker";
            this.DOBpicker.Size = new System.Drawing.Size(280, 22);
            this.DOBpicker.TabIndex = 3;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.roomNumberLabel.Location = new System.Drawing.Point(164, 250);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(76, 30);
            this.roomNumberLabel.TabIndex = 21;
            this.roomNumberLabel.Text = "Room #:";
            // 
            // roomNumber
            // 
            this.roomNumber.Location = new System.Drawing.Point(303, 250);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(280, 22);
            this.roomNumber.TabIndex = 4;
            // 
            // childNameLabel
            // 
            this.childNameLabel.AutoSize = true;
            this.childNameLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.childNameLabel.Location = new System.Drawing.Point(164, 62);
            this.childNameLabel.Name = "childNameLabel";
            this.childNameLabel.Size = new System.Drawing.Size(62, 30);
            this.childNameLabel.TabIndex = 16;
            this.childNameLabel.Text = "Name:";
            // 
            // groupedFeatures
            // 
            this.groupedFeatures.Controls.Add(this.feature9);
            this.groupedFeatures.Controls.Add(this.feature8);
            this.groupedFeatures.Controls.Add(this.feature7);
            this.groupedFeatures.Controls.Add(this.feature6);
            this.groupedFeatures.Controls.Add(this.feature5);
            this.groupedFeatures.Controls.Add(this.feature4);
            this.groupedFeatures.Controls.Add(this.feature3);
            this.groupedFeatures.Controls.Add(this.feature2);
            this.groupedFeatures.Controls.Add(this.feature1);
            this.groupedFeatures.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.groupedFeatures.Location = new System.Drawing.Point(23, 316);
            this.groupedFeatures.Name = "groupedFeatures";
            this.groupedFeatures.Size = new System.Drawing.Size(600, 200);
            this.groupedFeatures.TabIndex = 7;
            this.groupedFeatures.TabStop = false;
            this.groupedFeatures.Text = "Features";
            // 
            // feature9
            // 
            this.feature9.AutoSize = true;
            this.feature9.Location = new System.Drawing.Point(343, 146);
            this.feature9.Name = "feature9";
            this.feature9.Size = new System.Drawing.Size(100, 34);
            this.feature9.TabIndex = 16;
            this.feature9.Text = "Feature";
            this.feature9.UseVisualStyleBackColor = true;
            // 
            // feature8
            // 
            this.feature8.AutoSize = true;
            this.feature8.Location = new System.Drawing.Point(343, 97);
            this.feature8.Name = "feature8";
            this.feature8.Size = new System.Drawing.Size(100, 34);
            this.feature8.TabIndex = 13;
            this.feature8.Text = "Feature";
            this.feature8.UseVisualStyleBackColor = true;
            // 
            // feature7
            // 
            this.feature7.AutoSize = true;
            this.feature7.Location = new System.Drawing.Point(343, 49);
            this.feature7.Name = "feature7";
            this.feature7.Size = new System.Drawing.Size(100, 34);
            this.feature7.TabIndex = 10;
            this.feature7.Text = "Feature";
            this.feature7.UseVisualStyleBackColor = true;
            // 
            // feature6
            // 
            this.feature6.AutoSize = true;
            this.feature6.Location = new System.Drawing.Point(194, 146);
            this.feature6.Name = "feature6";
            this.feature6.Size = new System.Drawing.Size(100, 34);
            this.feature6.TabIndex = 15;
            this.feature6.Text = "Feature";
            this.feature6.UseVisualStyleBackColor = true;
            // 
            // feature5
            // 
            this.feature5.AutoSize = true;
            this.feature5.Location = new System.Drawing.Point(194, 97);
            this.feature5.Name = "feature5";
            this.feature5.Size = new System.Drawing.Size(100, 34);
            this.feature5.TabIndex = 12;
            this.feature5.Text = "Feature";
            this.feature5.UseVisualStyleBackColor = true;
            // 
            // feature4
            // 
            this.feature4.AutoSize = true;
            this.feature4.Location = new System.Drawing.Point(194, 49);
            this.feature4.Name = "feature4";
            this.feature4.Size = new System.Drawing.Size(100, 34);
            this.feature4.TabIndex = 9;
            this.feature4.Text = "Feature";
            this.feature4.UseVisualStyleBackColor = true;
            // 
            // feature3
            // 
            this.feature3.AutoSize = true;
            this.feature3.Location = new System.Drawing.Point(30, 146);
            this.feature3.Name = "feature3";
            this.feature3.Size = new System.Drawing.Size(100, 34);
            this.feature3.TabIndex = 14;
            this.feature3.Text = "Feature";
            this.feature3.UseVisualStyleBackColor = true;
            // 
            // feature2
            // 
            this.feature2.AutoSize = true;
            this.feature2.Location = new System.Drawing.Point(30, 97);
            this.feature2.Name = "feature2";
            this.feature2.Size = new System.Drawing.Size(100, 34);
            this.feature2.TabIndex = 11;
            this.feature2.Text = "Feature";
            this.feature2.UseVisualStyleBackColor = true;
            // 
            // feature1
            // 
            this.feature1.AutoSize = true;
            this.feature1.Checked = true;
            this.feature1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.feature1.Location = new System.Drawing.Point(30, 49);
            this.feature1.Name = "feature1";
            this.feature1.Size = new System.Drawing.Size(100, 34);
            this.feature1.TabIndex = 9;
            this.feature1.Text = "Feature";
            this.feature1.UseVisualStyleBackColor = true;
            // 
            // childName
            // 
            this.childName.Location = new System.Drawing.Point(303, 62);
            this.childName.Name = "childName";
            this.childName.Size = new System.Drawing.Size(280, 22);
            this.childName.TabIndex = 0;
            // 
            // childDOBLabel
            // 
            this.childDOBLabel.AutoSize = true;
            this.childDOBLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.childDOBLabel.Location = new System.Drawing.Point(164, 191);
            this.childDOBLabel.Name = "childDOBLabel";
            this.childDOBLabel.Size = new System.Drawing.Size(127, 30);
            this.childDOBLabel.TabIndex = 18;
            this.childDOBLabel.Text = "Date of Birth:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.genderLabel.Location = new System.Drawing.Point(164, 120);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(77, 30);
            this.genderLabel.TabIndex = 20;
            this.genderLabel.Text = "Gender:";
            // 
            // editButton
            // 
            this.editButton.AutoSize = true;
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.editButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.editButton.ForeColor = System.Drawing.Color.DimGray;
            this.editButton.Location = new System.Drawing.Point(639, 316);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(248, 44);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.childProfilePanel);
            this.HelpButton = true;
            this.Name = "Child";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nusery Management System - Child Profile";
            this.Load += new System.EventHandler(this.Child_Load);
            this.childProfilePanel.ResumeLayout(false);
            this.childProfilePanel.PerformLayout();
            this.genderPanel.ResumeLayout(false);
            this.genderPanel.PerformLayout();
            this.groupedFeatures.ResumeLayout(false);
            this.groupedFeatures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel childProfilePanel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label childDOBLabel;
        private System.Windows.Forms.TextBox childName;
        private System.Windows.Forms.CheckBox feature1;
        private System.Windows.Forms.CheckBox feature2;
        private System.Windows.Forms.CheckBox feature3;
        private System.Windows.Forms.CheckBox feature4;
        private System.Windows.Forms.CheckBox feature5;
        private System.Windows.Forms.CheckBox feature6;
        private System.Windows.Forms.CheckBox feature7;
        private System.Windows.Forms.CheckBox feature8;
        private System.Windows.Forms.CheckBox feature9;
        private System.Windows.Forms.GroupBox groupedFeatures;
        private System.Windows.Forms.Label childNameLabel;
        private System.Windows.Forms.TextBox roomNumber;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.DateTimePicker DOBpicker;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.Label detailsOfTheDayLabel;
        private System.Windows.Forms.Button importImageButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button childImageButton;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Panel genderPanel;
        private System.Windows.Forms.Button editButton;
    }
}