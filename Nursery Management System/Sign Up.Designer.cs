namespace Nursery_Management_System
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
            this.signButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffSignUp
            // 
            this.staffSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(187)))), ((int)(((byte)(173)))));
            this.staffSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffSignUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.staffSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffSignUp.Font = new System.Drawing.Font("Bebas", 15F);
            this.staffSignUp.Image = ((System.Drawing.Image)(resources.GetObject("staffSignUp.Image")));
            this.staffSignUp.Location = new System.Drawing.Point(460, 0);
            this.staffSignUp.Name = "staffSignUp";
            this.staffSignUp.Size = new System.Drawing.Size(460, 540);
            this.staffSignUp.TabIndex = 1;
            this.staffSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.staffSignUp.UseVisualStyleBackColor = false;
            // 
            // parentSignUp
            // 
            this.parentSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(220)))));
            this.parentSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parentSignUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.parentSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parentSignUp.Font = new System.Drawing.Font("Bebas", 15F);
            this.parentSignUp.ForeColor = System.Drawing.Color.Black;
            this.parentSignUp.Image = ((System.Drawing.Image)(resources.GetObject("parentSignUp.Image")));
            this.parentSignUp.Location = new System.Drawing.Point(0, 0);
            this.parentSignUp.Name = "parentSignUp";
            this.parentSignUp.Size = new System.Drawing.Size(460, 540);
            this.parentSignUp.TabIndex = 0;
            this.parentSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.parentSignUp.UseVisualStyleBackColor = false;
            this.parentSignUp.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signButtons
            // 
            this.signButtons.Controls.Add(this.staffSignUp);
            this.signButtons.Controls.Add(this.parentSignUp);
            this.signButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signButtons.Location = new System.Drawing.Point(0, 0);
            this.signButtons.Name = "signButtons";
            this.signButtons.Size = new System.Drawing.Size(920, 540);
            this.signButtons.TabIndex = 3;
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}