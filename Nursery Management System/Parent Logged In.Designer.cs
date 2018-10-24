namespace Nursery_Management_System
{
    partial class parentLoggedIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(parentLoggedIn));
            this.parentProfileButton = new System.Windows.Forms.Button();
            this.childrenButton = new System.Windows.Forms.Button();
            this.parentFeedbackButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // parentProfileButton
            // 
            this.parentProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.parentProfileButton.FlatAppearance.BorderSize = 0;
            this.parentProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parentProfileButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.parentProfileButton.Image = ((System.Drawing.Image)(resources.GetObject("parentProfileButton.Image")));
            this.parentProfileButton.Location = new System.Drawing.Point(0, 0);
            this.parentProfileButton.Name = "parentProfileButton";
            this.parentProfileButton.Size = new System.Drawing.Size(402, 270);
            this.parentProfileButton.TabIndex = 0;
            this.parentProfileButton.Text = "Profile";
            this.parentProfileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.parentProfileButton.UseVisualStyleBackColor = false;
            // 
            // childrenButton
            // 
            this.childrenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(187)))), ((int)(((byte)(173)))));
            this.childrenButton.FlatAppearance.BorderSize = 0;
            this.childrenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.childrenButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.childrenButton.Image = ((System.Drawing.Image)(resources.GetObject("childrenButton.Image")));
            this.childrenButton.Location = new System.Drawing.Point(402, 0);
            this.childrenButton.Name = "childrenButton";
            this.childrenButton.Size = new System.Drawing.Size(402, 270);
            this.childrenButton.TabIndex = 1;
            this.childrenButton.Text = "Children";
            this.childrenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.childrenButton.UseVisualStyleBackColor = false;
            // 
            // parentFeedbackButton
            // 
            this.parentFeedbackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            this.parentFeedbackButton.FlatAppearance.BorderSize = 0;
            this.parentFeedbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parentFeedbackButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.parentFeedbackButton.Image = ((System.Drawing.Image)(resources.GetObject("parentFeedbackButton.Image")));
            this.parentFeedbackButton.Location = new System.Drawing.Point(0, 270);
            this.parentFeedbackButton.Name = "parentFeedbackButton";
            this.parentFeedbackButton.Size = new System.Drawing.Size(402, 270);
            this.parentFeedbackButton.TabIndex = 2;
            this.parentFeedbackButton.Text = "Feedback";
            this.parentFeedbackButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.parentFeedbackButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(402, 270);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(402, 270);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Settings";
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.settingsButton.UseVisualStyleBackColor = false;
            // 
            // parentLoggedIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 540);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.parentFeedbackButton);
            this.Controls.Add(this.childrenButton);
            this.Controls.Add(this.parentProfileButton);
            this.Name = "parentLoggedIn";
            this.Text = "Nursery Management System";
            this.Load += new System.EventHandler(this.Parent_Logged_In_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button parentProfileButton;
        private System.Windows.Forms.Button childrenButton;
        private System.Windows.Forms.Button parentFeedbackButton;
        private System.Windows.Forms.Button settingsButton;
    }
}