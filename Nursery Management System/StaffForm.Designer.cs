using System;

namespace Nursery_Management_System
{
    partial class staffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffForm));
            this.IDLabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.staffFirstNameLabel = new System.Windows.Forms.Label();
            this.staffProfilePanel = new System.Windows.Forms.Panel();
            this.staffProfilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            resources.ApplyResources(this.IDLabel, "IDLabel");
            this.IDLabel.ForeColor = System.Drawing.Color.DimGray;
            this.IDLabel.Name = "IDLabel";
            // 
            // ID
            // 
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.UseWaitCursor = true;
            // 
            // lastNameLabel
            // 
            resources.ApplyResources(this.lastNameLabel, "lastNameLabel");
            this.lastNameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.lastNameLabel.Name = "lastNameLabel";
            // 
            // lastName
            // 
            resources.ApplyResources(this.lastName, "lastName");
            this.lastName.Name = "lastName";
            // 
            // phoneNumberLabel
            // 
            resources.ApplyResources(this.phoneNumberLabel, "phoneNumberLabel");
            this.phoneNumberLabel.ForeColor = System.Drawing.Color.DimGray;
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            // 
            // phoneNumber
            // 
            resources.ApplyResources(this.phoneNumber, "phoneNumber");
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.UseWaitCursor = true;
            // 
            // emailLabel
            // 
            resources.ApplyResources(this.emailLabel, "emailLabel");
            this.emailLabel.ForeColor = System.Drawing.Color.DimGray;
            this.emailLabel.Name = "emailLabel";
            // 
            // email
            // 
            resources.ApplyResources(this.email, "email");
            this.email.Name = "email";
            this.email.UseWaitCursor = true;
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.ForeColor = System.Drawing.Color.DimGray;
            this.passwordLabel.Name = "passwordLabel";
            // 
            // password
            // 
            resources.ApplyResources(this.password, "password");
            this.password.Name = "password";
            this.password.UseSystemPasswordChar = true;
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.usernameLabel.Name = "usernameLabel";
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.Name = "username";
            // 
            // signUpButton
            // 
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.signUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.signUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.signUpButton, "signUpButton");
            this.signUpButton.ForeColor = System.Drawing.Color.DimGray;
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // firstName
            // 
            resources.ApplyResources(this.firstName, "firstName");
            this.firstName.Name = "firstName";
            // 
            // backButton
            // 
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // staffFirstNameLabel
            // 
            resources.ApplyResources(this.staffFirstNameLabel, "staffFirstNameLabel");
            this.staffFirstNameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.staffFirstNameLabel.Name = "staffFirstNameLabel";
            // 
            // staffProfilePanel
            // 
            this.staffProfilePanel.BackColor = System.Drawing.Color.Transparent;
            this.staffProfilePanel.Controls.Add(this.IDLabel);
            this.staffProfilePanel.Controls.Add(this.ID);
            this.staffProfilePanel.Controls.Add(this.lastNameLabel);
            this.staffProfilePanel.Controls.Add(this.lastName);
            this.staffProfilePanel.Controls.Add(this.phoneNumberLabel);
            this.staffProfilePanel.Controls.Add(this.phoneNumber);
            this.staffProfilePanel.Controls.Add(this.emailLabel);
            this.staffProfilePanel.Controls.Add(this.email);
            this.staffProfilePanel.Controls.Add(this.passwordLabel);
            this.staffProfilePanel.Controls.Add(this.password);
            this.staffProfilePanel.Controls.Add(this.usernameLabel);
            this.staffProfilePanel.Controls.Add(this.username);
            this.staffProfilePanel.Controls.Add(this.signUpButton);
            this.staffProfilePanel.Controls.Add(this.staffFirstNameLabel);
            this.staffProfilePanel.Controls.Add(this.firstName);
            resources.ApplyResources(this.staffProfilePanel, "staffProfilePanel");
            this.staffProfilePanel.Name = "staffProfilePanel";
            // 
            // staffForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.staffProfilePanel);
            this.Name = "staffForm";
            this.Load += new System.EventHandler(this.staffForm_Load);
            this.staffProfilePanel.ResumeLayout(false);
            this.staffProfilePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel staffProfilePanel;
        private System.Windows.Forms.Label staffFirstNameLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label IDLabel;

        public EventHandler StaffForm_Load { get; private set; }
    }
}