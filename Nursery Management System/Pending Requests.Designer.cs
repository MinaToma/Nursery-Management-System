namespace Nursery_Management_System
{
    partial class adminPendingRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminPendingRequests));
            this.pendingRequestsControl = new System.Windows.Forms.TabControl();
            this.staff = new System.Windows.Forms.TabPage();
            this.backButtonStaff = new System.Windows.Forms.Button();
            this.child = new System.Windows.Forms.TabPage();
            this.backButtonChild = new System.Windows.Forms.Button();
            this.Parents = new System.Windows.Forms.TabPage();
            this.backButtonParents = new System.Windows.Forms.Button();
            this.pendingRequestsControl.SuspendLayout();
            this.staff.SuspendLayout();
            this.child.SuspendLayout();
            this.Parents.SuspendLayout();
            this.SuspendLayout();
            // 
            // pendingRequestsControl
            // 
            this.pendingRequestsControl.Controls.Add(this.staff);
            this.pendingRequestsControl.Controls.Add(this.child);
            this.pendingRequestsControl.Controls.Add(this.Parents);
            this.pendingRequestsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendingRequestsControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pendingRequestsControl.Location = new System.Drawing.Point(0, 0);
            this.pendingRequestsControl.Name = "pendingRequestsControl";
            this.pendingRequestsControl.Padding = new System.Drawing.Point(10, 10);
            this.pendingRequestsControl.SelectedIndex = 0;
            this.pendingRequestsControl.Size = new System.Drawing.Size(920, 540);
            this.pendingRequestsControl.TabIndex = 0;
            // 
            // staff
            // 
            this.staff.Controls.Add(this.backButtonStaff);
            this.staff.Location = new System.Drawing.Point(4, 52);
            this.staff.Name = "staff";
            this.staff.Padding = new System.Windows.Forms.Padding(3);
            this.staff.Size = new System.Drawing.Size(912, 484);
            this.staff.TabIndex = 0;
            this.staff.Text = "Staff";
            this.staff.UseVisualStyleBackColor = true;
            // 
            // backButtonStaff
            // 
            this.backButtonStaff.AutoSize = true;
            this.backButtonStaff.BackColor = System.Drawing.Color.Transparent;
            this.backButtonStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButtonStaff.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButtonStaff.FlatAppearance.BorderSize = 0;
            this.backButtonStaff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButtonStaff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButtonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButtonStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backButtonStaff.Image = ((System.Drawing.Image)(resources.GetObject("backButtonStaff.Image")));
            this.backButtonStaff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backButtonStaff.Location = new System.Drawing.Point(6, 386);
            this.backButtonStaff.Name = "backButtonStaff";
            this.backButtonStaff.Size = new System.Drawing.Size(107, 90);
            this.backButtonStaff.TabIndex = 10;
            this.backButtonStaff.UseVisualStyleBackColor = false;
            this.backButtonStaff.Click += new System.EventHandler(this.backButtonStaff_Click);
            // 
            // child
            // 
            this.child.Controls.Add(this.backButtonChild);
            this.child.Location = new System.Drawing.Point(4, 52);
            this.child.Name = "child";
            this.child.Padding = new System.Windows.Forms.Padding(3);
            this.child.Size = new System.Drawing.Size(912, 484);
            this.child.TabIndex = 1;
            this.child.Text = "Child";
            this.child.UseVisualStyleBackColor = true;
            // 
            // backButtonChild
            // 
            this.backButtonChild.AutoSize = true;
            this.backButtonChild.BackColor = System.Drawing.Color.Transparent;
            this.backButtonChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButtonChild.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButtonChild.FlatAppearance.BorderSize = 0;
            this.backButtonChild.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButtonChild.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButtonChild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButtonChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backButtonChild.Image = ((System.Drawing.Image)(resources.GetObject("backButtonChild.Image")));
            this.backButtonChild.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backButtonChild.Location = new System.Drawing.Point(6, 386);
            this.backButtonChild.Name = "backButtonChild";
            this.backButtonChild.Size = new System.Drawing.Size(107, 90);
            this.backButtonChild.TabIndex = 10;
            this.backButtonChild.UseVisualStyleBackColor = false;
            this.backButtonChild.Click += new System.EventHandler(this.backButtonChild_Click);
            // 
            // Parents
            // 
            this.Parents.Controls.Add(this.backButtonParents);
            this.Parents.Location = new System.Drawing.Point(4, 52);
            this.Parents.Name = "Parents";
            this.Parents.Padding = new System.Windows.Forms.Padding(3);
            this.Parents.Size = new System.Drawing.Size(912, 484);
            this.Parents.TabIndex = 2;
            this.Parents.Text = "Parents";
            this.Parents.UseVisualStyleBackColor = true;
            // 
            // backButtonParents
            // 
            this.backButtonParents.AutoSize = true;
            this.backButtonParents.BackColor = System.Drawing.Color.Transparent;
            this.backButtonParents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButtonParents.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backButtonParents.FlatAppearance.BorderSize = 0;
            this.backButtonParents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backButtonParents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backButtonParents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButtonParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.backButtonParents.Image = ((System.Drawing.Image)(resources.GetObject("backButtonParents.Image")));
            this.backButtonParents.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backButtonParents.Location = new System.Drawing.Point(6, 386);
            this.backButtonParents.Name = "backButtonParents";
            this.backButtonParents.Size = new System.Drawing.Size(107, 90);
            this.backButtonParents.TabIndex = 11;
            this.backButtonParents.UseVisualStyleBackColor = false;
            this.backButtonParents.Click += new System.EventHandler(this.backButtonParents_Click);
            // 
            // adminPendingRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.pendingRequestsControl);
            this.Name = "adminPendingRequests";
            this.Text = "Nursery Management System - Pending Requests";
            this.pendingRequestsControl.ResumeLayout(false);
            this.staff.ResumeLayout(false);
            this.staff.PerformLayout();
            this.child.ResumeLayout(false);
            this.child.PerformLayout();
            this.Parents.ResumeLayout(false);
            this.Parents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pendingRequestsControl;
        private System.Windows.Forms.TabPage staff;
        private System.Windows.Forms.TabPage child;
        private System.Windows.Forms.Button backButtonStaff;
        private System.Windows.Forms.Button backButtonChild;
        private System.Windows.Forms.TabPage Parents;
        private System.Windows.Forms.Button backButtonParents;
    }
}