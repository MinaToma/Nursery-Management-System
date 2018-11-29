namespace Nursery_Management_System
{
    partial class staffLoggedIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffLoggedIn));
            this.signOutButton = new System.Windows.Forms.Button();
            this.staffFeedbackButton = new System.Windows.Forms.Button();
            this.roomButton = new System.Windows.Forms.Button();
            this.staffProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signOutButton
            // 
            this.signOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.signOutButton.FlatAppearance.BorderSize = 0;
            this.signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.signOutButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.signOutButton.Image = ((System.Drawing.Image)(resources.GetObject("signOutButton.Image")));
            this.signOutButton.Location = new System.Drawing.Point(459, 270);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(459, 270);
            this.signOutButton.TabIndex = 7;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.signOutButton.UseVisualStyleBackColor = false;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // staffFeedbackButton
            // 
            this.staffFeedbackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            this.staffFeedbackButton.FlatAppearance.BorderSize = 0;
            this.staffFeedbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffFeedbackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.staffFeedbackButton.Image = ((System.Drawing.Image)(resources.GetObject("staffFeedbackButton.Image")));
            this.staffFeedbackButton.Location = new System.Drawing.Point(1, 270);
            this.staffFeedbackButton.Name = "staffFeedbackButton";
            this.staffFeedbackButton.Size = new System.Drawing.Size(459, 270);
            this.staffFeedbackButton.TabIndex = 6;
            this.staffFeedbackButton.Text = "Feedback";
            this.staffFeedbackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.staffFeedbackButton.UseVisualStyleBackColor = false;
            // 
            // roomButton
            // 
            this.roomButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(187)))), ((int)(((byte)(173)))));
            this.roomButton.FlatAppearance.BorderSize = 0;
            this.roomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.roomButton.Image = ((System.Drawing.Image)(resources.GetObject("roomButton.Image")));
            this.roomButton.Location = new System.Drawing.Point(459, 0);
            this.roomButton.Name = "roomButton";
            this.roomButton.Size = new System.Drawing.Size(459, 270);
            this.roomButton.TabIndex = 5;
            this.roomButton.Text = "Room";
            this.roomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roomButton.UseVisualStyleBackColor = false;
            this.roomButton.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // staffProfileButton
            // 
            this.staffProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.staffProfileButton.FlatAppearance.BorderSize = 0;
            this.staffProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.staffProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("staffProfileButton.Image")));
            this.staffProfileButton.Location = new System.Drawing.Point(1, 0);
            this.staffProfileButton.Name = "staffProfileButton";
            this.staffProfileButton.Size = new System.Drawing.Size(459, 270);
            this.staffProfileButton.TabIndex = 4;
            this.staffProfileButton.Text = "Profile";
            this.staffProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.staffProfileButton.UseVisualStyleBackColor = false;
            this.staffProfileButton.Click += new System.EventHandler(this.staffProfileButton_Click);
            // 
            // staffLoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.staffFeedbackButton);
            this.Controls.Add(this.roomButton);
            this.Controls.Add(this.staffProfileButton);
            this.Name = "staffLoggedIn";
            this.Text = "Nursery Management System - Logged In as Staff ";
            this.Load += new System.EventHandler(this.staffLoggedIn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.Button staffFeedbackButton;
        private System.Windows.Forms.Button roomButton;
        private System.Windows.Forms.Button staffProfileButton;
    }
}