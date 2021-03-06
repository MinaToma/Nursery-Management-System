﻿namespace Nursery_Management_System
{
    partial class signUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signUp));
            this.staffSignUp = new System.Windows.Forms.Button();
            this.parentSignUp = new System.Windows.Forms.Button();
            this.signButtons = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.signButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffSignUp
            // 
            this.staffSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(187)))), ((int)(((byte)(173)))));
            this.staffSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffSignUp.FlatAppearance.BorderSize = 0;
            this.staffSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.staffSignUp.Image = ((System.Drawing.Image)(resources.GetObject("staffSignUp.Image")));
            this.staffSignUp.Location = new System.Drawing.Point(460, 60);
            this.staffSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.staffSignUp.Name = "staffSignUp";
            this.staffSignUp.Size = new System.Drawing.Size(460, 480);
            this.staffSignUp.TabIndex = 1;
            this.staffSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.staffSignUp.UseVisualStyleBackColor = false;
            this.staffSignUp.Click += new System.EventHandler(this.staffSignUp_Click);
            // 
            // parentSignUp
            // 
            this.parentSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.parentSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parentSignUp.FlatAppearance.BorderSize = 0;
            this.parentSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parentSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.parentSignUp.ForeColor = System.Drawing.Color.Black;
            this.parentSignUp.Image = ((System.Drawing.Image)(resources.GetObject("parentSignUp.Image")));
            this.parentSignUp.Location = new System.Drawing.Point(0, 60);
            this.parentSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.parentSignUp.Name = "parentSignUp";
            this.parentSignUp.Size = new System.Drawing.Size(460, 480);
            this.parentSignUp.TabIndex = 0;
            this.parentSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.parentSignUp.UseVisualStyleBackColor = false;
            this.parentSignUp.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signButtons
            // 
            this.signButtons.BackColor = System.Drawing.Color.Transparent;
            this.signButtons.Controls.Add(this.backButton);
            this.signButtons.Controls.Add(this.parentSignUp);
            this.signButtons.Controls.Add(this.staffSignUp);
            this.signButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signButtons.Location = new System.Drawing.Point(0, 0);
            this.signButtons.Name = "signButtons";
            this.signButtons.Size = new System.Drawing.Size(920, 540);
            this.signButtons.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(920, 60);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.signButtons);
            this.Name = "signUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nursery Management System - Sign Up";
            this.Load += new System.EventHandler(this.signUp_Load);
            this.signButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button staffSignUp;
        private System.Windows.Forms.Button parentSignUp;
        private System.Windows.Forms.Panel signButtons;
        private System.Windows.Forms.Button backButton;
    }
}