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
            this.childNameLabel = new System.Windows.Forms.Label();
            this.childName = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.TextBox();
            this.childDOBLabel = new System.Windows.Forms.Label();
            this.groupedFeatures = new System.Windows.Forms.GroupBox();
            this.feature1 = new System.Windows.Forms.CheckBox();
            this.feature2 = new System.Windows.Forms.CheckBox();
            this.feature3 = new System.Windows.Forms.CheckBox();
            this.feature6 = new System.Windows.Forms.CheckBox();
            this.feature5 = new System.Windows.Forms.CheckBox();
            this.feature4 = new System.Windows.Forms.CheckBox();
            this.feature9 = new System.Windows.Forms.CheckBox();
            this.feature8 = new System.Windows.Forms.CheckBox();
            this.feature7 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomNumber = new System.Windows.Forms.TextBox();
            this.childImageButton = new System.Windows.Forms.Button();
            this.groupedFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // childNameLabel
            // 
            this.childNameLabel.AutoSize = true;
            this.childNameLabel.Enabled = false;
            this.childNameLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.childNameLabel.Location = new System.Drawing.Point(169, 72);
            this.childNameLabel.Name = "childNameLabel";
            this.childNameLabel.Size = new System.Drawing.Size(62, 30);
            this.childNameLabel.TabIndex = 0;
            this.childNameLabel.Text = "Name:";
            this.childNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // childName
            // 
            this.childName.Enabled = false;
            this.childName.Location = new System.Drawing.Point(308, 72);
            this.childName.Name = "childName";
            this.childName.ReadOnly = true;
            this.childName.Size = new System.Drawing.Size(261, 22);
            this.childName.TabIndex = 0;
            this.childName.TextChanged += new System.EventHandler(this.childName_TextChanged);
            // 
            // DOB
            // 
            this.DOB.Enabled = false;
            this.DOB.Location = new System.Drawing.Point(308, 166);
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Size = new System.Drawing.Size(261, 22);
            this.DOB.TabIndex = 1;
            this.DOB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // childDOBLabel
            // 
            this.childDOBLabel.AutoSize = true;
            this.childDOBLabel.Enabled = false;
            this.childDOBLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.childDOBLabel.Location = new System.Drawing.Point(169, 166);
            this.childDOBLabel.Name = "childDOBLabel";
            this.childDOBLabel.Size = new System.Drawing.Size(127, 30);
            this.childDOBLabel.TabIndex = 1;
            this.childDOBLabel.Text = "Date of Birth:";
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
            this.groupedFeatures.Enabled = false;
            this.groupedFeatures.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.groupedFeatures.Location = new System.Drawing.Point(160, 300);
            this.groupedFeatures.Name = "groupedFeatures";
            this.groupedFeatures.Size = new System.Drawing.Size(600, 200);
            this.groupedFeatures.TabIndex = 3;
            this.groupedFeatures.TabStop = false;
            this.groupedFeatures.Text = "Features";
            this.groupedFeatures.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // feature1
            // 
            this.feature1.AutoSize = true;
            this.feature1.Checked = true;
            this.feature1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.feature1.Location = new System.Drawing.Point(30, 49);
            this.feature1.Name = "feature1";
            this.feature1.Size = new System.Drawing.Size(100, 34);
            this.feature1.TabIndex = 0;
            this.feature1.Text = "Feature";
            this.feature1.UseVisualStyleBackColor = true;
            // 
            // feature2
            // 
            this.feature2.AutoSize = true;
            this.feature2.Location = new System.Drawing.Point(30, 97);
            this.feature2.Name = "feature2";
            this.feature2.Size = new System.Drawing.Size(100, 34);
            this.feature2.TabIndex = 1;
            this.feature2.Text = "Feature";
            this.feature2.UseVisualStyleBackColor = true;
            // 
            // feature3
            // 
            this.feature3.AutoSize = true;
            this.feature3.Location = new System.Drawing.Point(30, 146);
            this.feature3.Name = "feature3";
            this.feature3.Size = new System.Drawing.Size(100, 34);
            this.feature3.TabIndex = 2;
            this.feature3.Text = "Feature";
            this.feature3.UseVisualStyleBackColor = true;
            // 
            // feature6
            // 
            this.feature6.AutoSize = true;
            this.feature6.Location = new System.Drawing.Point(194, 146);
            this.feature6.Name = "feature6";
            this.feature6.Size = new System.Drawing.Size(100, 34);
            this.feature6.TabIndex = 5;
            this.feature6.Text = "Feature";
            this.feature6.UseVisualStyleBackColor = true;
            // 
            // feature5
            // 
            this.feature5.AutoSize = true;
            this.feature5.Location = new System.Drawing.Point(194, 97);
            this.feature5.Name = "feature5";
            this.feature5.Size = new System.Drawing.Size(100, 34);
            this.feature5.TabIndex = 4;
            this.feature5.Text = "Feature";
            this.feature5.UseVisualStyleBackColor = true;
            // 
            // feature4
            // 
            this.feature4.AutoSize = true;
            this.feature4.Location = new System.Drawing.Point(194, 49);
            this.feature4.Name = "feature4";
            this.feature4.Size = new System.Drawing.Size(100, 34);
            this.feature4.TabIndex = 3;
            this.feature4.Text = "Feature";
            this.feature4.UseVisualStyleBackColor = true;
            // 
            // feature9
            // 
            this.feature9.AutoSize = true;
            this.feature9.Location = new System.Drawing.Point(343, 146);
            this.feature9.Name = "feature9";
            this.feature9.Size = new System.Drawing.Size(100, 34);
            this.feature9.TabIndex = 8;
            this.feature9.Text = "Feature";
            this.feature9.UseVisualStyleBackColor = true;
            // 
            // feature8
            // 
            this.feature8.AutoSize = true;
            this.feature8.Location = new System.Drawing.Point(343, 97);
            this.feature8.Name = "feature8";
            this.feature8.Size = new System.Drawing.Size(100, 34);
            this.feature8.TabIndex = 7;
            this.feature8.Text = "Feature";
            this.feature8.UseVisualStyleBackColor = true;
            // 
            // feature7
            // 
            this.feature7.AutoSize = true;
            this.feature7.Location = new System.Drawing.Point(343, 49);
            this.feature7.Name = "feature7";
            this.feature7.Size = new System.Drawing.Size(100, 34);
            this.feature7.TabIndex = 6;
            this.feature7.Text = "Feature";
            this.feature7.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(308, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(261, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Enabled = false;
            this.genderLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.genderLabel.Location = new System.Drawing.Point(169, 118);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(77, 30);
            this.genderLabel.TabIndex = 5;
            this.genderLabel.Text = "Gender:";
            this.genderLabel.Click += new System.EventHandler(this.label1_Click_1);
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
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 90);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Enabled = false;
            this.roomNumberLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.roomNumberLabel.Location = new System.Drawing.Point(169, 213);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(76, 30);
            this.roomNumberLabel.TabIndex = 6;
            this.roomNumberLabel.Text = "Room #:";
            // 
            // roomNumber
            // 
            this.roomNumber.Enabled = false;
            this.roomNumber.Location = new System.Drawing.Point(308, 213);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.ReadOnly = true;
            this.roomNumber.Size = new System.Drawing.Size(261, 22);
            this.roomNumber.TabIndex = 7;
            this.roomNumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // childImageButton
            // 
            this.childImageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.childImageButton.FlatAppearance.BorderSize = 0;
            this.childImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.childImageButton.Image = ((System.Drawing.Image)(resources.GetObject("childImageButton.Image")));
            this.childImageButton.Location = new System.Drawing.Point(634, 12);
            this.childImageButton.Name = "childImageButton";
            this.childImageButton.Size = new System.Drawing.Size(248, 288);
            this.childImageButton.TabIndex = 8;
            this.childImageButton.UseVisualStyleBackColor = true;
            this.childImageButton.Click += new System.EventHandler(this.childImageButton_Click);
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.CancelButton = this.backButton;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.childImageButton);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.roomNumber);
            this.Controls.Add(this.childNameLabel);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupedFeatures);
            this.Controls.Add(this.childName);
            this.Controls.Add(this.childDOBLabel);
            this.Controls.Add(this.genderLabel);
            this.HelpButton = true;
            this.Name = "Child";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nusery Management System - Child Profile";
            this.groupedFeatures.ResumeLayout(false);
            this.groupedFeatures.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label childNameLabel;
        private System.Windows.Forms.TextBox childName;
        private System.Windows.Forms.TextBox DOB;
        private System.Windows.Forms.Label childDOBLabel;
        private System.Windows.Forms.GroupBox groupedFeatures;
        private System.Windows.Forms.CheckBox feature9;
        private System.Windows.Forms.CheckBox feature8;
        private System.Windows.Forms.CheckBox feature7;
        private System.Windows.Forms.CheckBox feature6;
        private System.Windows.Forms.CheckBox feature5;
        private System.Windows.Forms.CheckBox feature4;
        private System.Windows.Forms.CheckBox feature3;
        private System.Windows.Forms.CheckBox feature2;
        private System.Windows.Forms.CheckBox feature1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.TextBox roomNumber;
        private System.Windows.Forms.Button childImageButton;
    }
}