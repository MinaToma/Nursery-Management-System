namespace Nursery_Management_System
{
    partial class Admin_Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Feedback));
            this.feedbackBox = new System.Windows.Forms.RichTextBox();
            this.parentNameLabel = new System.Windows.Forms.Label();
            this.parentName = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feedbackBox
            // 
            this.feedbackBox.BackColor = System.Drawing.Color.LavenderBlush;
            this.feedbackBox.Font = new System.Drawing.Font("Comfortaa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackBox.Location = new System.Drawing.Point(150, 200);
            this.feedbackBox.Name = "feedbackBox";
            this.feedbackBox.Size = new System.Drawing.Size(620, 200);
            this.feedbackBox.TabIndex = 0;
            this.feedbackBox.Text = "";
            this.feedbackBox.TextChanged += new System.EventHandler(this.feedbackBox_TextChanged);
            // 
            // parentNameLabel
            // 
            this.parentNameLabel.AutoSize = true;
            this.parentNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.parentNameLabel.Font = new System.Drawing.Font("Bebas Neue", 20F);
            this.parentNameLabel.Location = new System.Drawing.Point(145, 107);
            this.parentNameLabel.Name = "parentNameLabel";
            this.parentNameLabel.Size = new System.Drawing.Size(180, 41);
            this.parentNameLabel.TabIndex = 1;
            this.parentNameLabel.Text = "Parent Name : ";
            // 
            // parentName
            // 
            this.parentName.AutoSize = true;
            this.parentName.BackColor = System.Drawing.Color.Transparent;
            this.parentName.Font = new System.Drawing.Font("Bebas Neue", 20F);
            this.parentName.Location = new System.Drawing.Point(331, 107);
            this.parentName.Name = "parentName";
            this.parentName.Size = new System.Drawing.Size(30, 41);
            this.parentName.TabIndex = 2;
            this.parentName.Text = "..";
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.nextButton.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Image")));
            this.nextButton.Location = new System.Drawing.Point(800, 430);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(80, 80);
            this.nextButton.TabIndex = 3;
            this.nextButton.UseVisualStyleBackColor = false;
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.Transparent;
            this.previousButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousButton.FlatAppearance.BorderSize = 0;
            this.previousButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.previousButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.previousButton.Image = ((System.Drawing.Image)(resources.GetObject("previousButton.Image")));
            this.previousButton.Location = new System.Drawing.Point(30, 430);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(80, 80);
            this.previousButton.TabIndex = 4;
            this.previousButton.UseVisualStyleBackColor = false;
            // 
            // Admin_Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.parentName);
            this.Controls.Add(this.parentNameLabel);
            this.Controls.Add(this.feedbackBox);
            this.Name = "Admin_Feedback";
            this.Text = "Nusery Management System - Admin Feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox feedbackBox;
        private System.Windows.Forms.Label parentNameLabel;
        private System.Windows.Forms.Label parentName;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
    }
}