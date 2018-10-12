namespace Nursery_Managemet_System
{
    partial class Sign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign));
            this.signButtons = new System.Windows.Forms.Panel();
            this.signUpButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.signButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // signButtons
            // 
            this.signButtons.Controls.Add(this.signUpButton);
            this.signButtons.Controls.Add(this.signInButton);
            this.signButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signButtons.Location = new System.Drawing.Point(0, 0);
            this.signButtons.Name = "signButtons";
            this.signButtons.Size = new System.Drawing.Size(920, 540);
            this.signButtons.TabIndex = 2;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.OliveDrab;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Bebas", 15F);
            this.signUpButton.Image = ((System.Drawing.Image)(resources.GetObject("signUpButton.Image")));
            this.signUpButton.Location = new System.Drawing.Point(460, 0);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(460, 540);
            this.signUpButton.TabIndex = 1;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.signUpButton.UseVisualStyleBackColor = false;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Bebas", 15F);
            this.signInButton.ForeColor = System.Drawing.Color.Black;
            this.signInButton.Image = ((System.Drawing.Image)(resources.GetObject("signInButton.Image")));
            this.signInButton.Location = new System.Drawing.Point(0, 0);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(460, 540);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign In";
            this.signInButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signIn_Click);
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.signButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sign";
            this.Text = "Nursery Management";
            this.signButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel signButtons;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button signInButton;
    }
}

