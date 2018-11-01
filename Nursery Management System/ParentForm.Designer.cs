namespace Nursery_Management_System
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.parentImageButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.importImageButton = new System.Windows.Forms.Button();
            this.parentName = new System.Windows.Forms.TextBox();
            this.parentNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.parentProfilePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addChildButton = new System.Windows.Forms.Button();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.creditCardLabel = new System.Windows.Forms.Label();
            this.creditcard = new System.Windows.Forms.TextBox();
            this.parentProfilePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parentImageButton
            // 
            this.parentImageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parentImageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(234)))), ((int)(((byte)(229)))));
            this.parentImageButton.FlatAppearance.BorderSize = 0;
            this.parentImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.parentImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.parentImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parentImageButton.Image = ((System.Drawing.Image)(resources.GetObject("parentImageButton.Image")));
            this.parentImageButton.Location = new System.Drawing.Point(639, 25);
            this.parentImageButton.Name = "parentImageButton";
            this.parentImageButton.Size = new System.Drawing.Size(248, 256);
            this.parentImageButton.TabIndex = 23;
            this.parentImageButton.UseVisualStyleBackColor = true;
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
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
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
            this.importImageButton.Location = new System.Drawing.Point(639, 287);
            this.importImageButton.Name = "importImageButton";
            this.importImageButton.Size = new System.Drawing.Size(248, 44);
            this.importImageButton.TabIndex = 26;
            this.importImageButton.Text = "Import Image";
            this.importImageButton.UseVisualStyleBackColor = true;
            // 
            // parentName
            // 
            this.parentName.Location = new System.Drawing.Point(305, 36);
            this.parentName.Name = "parentName";
            this.parentName.Size = new System.Drawing.Size(280, 22);
            this.parentName.TabIndex = 17;
            // 
            // parentNameLabel
            // 
            this.parentNameLabel.AutoSize = true;
            this.parentNameLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.parentNameLabel.Location = new System.Drawing.Point(166, 36);
            this.parentNameLabel.Name = "parentNameLabel";
            this.parentNameLabel.Size = new System.Drawing.Size(62, 30);
            this.parentNameLabel.TabIndex = 16;
            this.parentNameLabel.Text = "Name:";
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
            this.backButton.Location = new System.Drawing.Point(-1, -1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 90);
            this.backButton.TabIndex = 2;
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // parentProfilePanel
            // 
            this.parentProfilePanel.Controls.Add(this.panel1);
            this.parentProfilePanel.Controls.Add(this.phoneNumberLabel);
            this.parentProfilePanel.Controls.Add(this.phoneNumber);
            this.parentProfilePanel.Controls.Add(this.addressLabel);
            this.parentProfilePanel.Controls.Add(this.address);
            this.parentProfilePanel.Controls.Add(this.passwordLabel);
            this.parentProfilePanel.Controls.Add(this.password);
            this.parentProfilePanel.Controls.Add(this.creditCardLabel);
            this.parentProfilePanel.Controls.Add(this.creditcard);
            this.parentProfilePanel.Controls.Add(this.parentImageButton);
            this.parentProfilePanel.Controls.Add(this.saveButton);
            this.parentProfilePanel.Controls.Add(this.importImageButton);
            this.parentProfilePanel.Controls.Add(this.parentNameLabel);
            this.parentProfilePanel.Controls.Add(this.parentName);
            this.parentProfilePanel.Location = new System.Drawing.Point(1, 2);
            this.parentProfilePanel.Name = "parentProfilePanel";
            this.parentProfilePanel.Size = new System.Drawing.Size(920, 540);
            this.parentProfilePanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addChildButton);
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 212);
            this.panel1.TabIndex = 36;
            // 
            // addChildButton
            // 
            this.addChildButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addChildButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addChildButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addChildButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addChildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addChildButton.Font = new System.Drawing.Font("Bebas Neue", 13F);
            this.addChildButton.Image = ((System.Drawing.Image)(resources.GetObject("addChildButton.Image")));
            this.addChildButton.Location = new System.Drawing.Point(28, 29);
            this.addChildButton.Name = "addChildButton";
            this.addChildButton.Size = new System.Drawing.Size(200, 167);
            this.addChildButton.TabIndex = 37;
            this.addChildButton.Text = "add child";
            this.addChildButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addChildButton.UseVisualStyleBackColor = true;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.phoneNumberLabel.Location = new System.Drawing.Point(166, 86);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(136, 30);
            this.phoneNumberLabel.TabIndex = 34;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(305, 86);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(280, 22);
            this.phoneNumber.TabIndex = 35;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.addressLabel.Location = new System.Drawing.Point(166, 138);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(85, 30);
            this.addressLabel.TabIndex = 32;
            this.addressLabel.Text = "Address:";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(305, 138);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(280, 22);
            this.address.TabIndex = 33;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.passwordLabel.Location = new System.Drawing.Point(166, 192);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(99, 30);
            this.passwordLabel.TabIndex = 30;
            this.passwordLabel.Text = "Password:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(305, 192);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(280, 22);
            this.password.TabIndex = 31;
            // 
            // creditCardLabel
            // 
            this.creditCardLabel.AutoSize = true;
            this.creditCardLabel.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.creditCardLabel.Location = new System.Drawing.Point(166, 251);
            this.creditCardLabel.Name = "creditCardLabel";
            this.creditCardLabel.Size = new System.Drawing.Size(115, 30);
            this.creditCardLabel.TabIndex = 28;
            this.creditCardLabel.Text = "Credit Card:";
            // 
            // creditcard
            // 
            this.creditcard.Location = new System.Drawing.Point(305, 251);
            this.creditcard.Name = "creditcard";
            this.creditcard.Size = new System.Drawing.Size(280, 22);
            this.creditcard.TabIndex = 29;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(236)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.parentProfilePanel);
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nursery Management System - Sign Up as Parent";
            this.parentProfilePanel.ResumeLayout(false);
            this.parentProfilePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button parentImageButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button importImageButton;
        private System.Windows.Forms.TextBox parentName;
        private System.Windows.Forms.Label parentNameLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel parentProfilePanel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label creditCardLabel;
        private System.Windows.Forms.TextBox creditcard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addChildButton;
    }
}