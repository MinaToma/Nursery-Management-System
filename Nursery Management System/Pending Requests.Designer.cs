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
            this.pendingRequestsControl = new System.Windows.Forms.TabControl();
            this.staff = new System.Windows.Forms.TabPage();
            this.parents = new System.Windows.Forms.TabPage();
            this.staffRequests = new System.Windows.Forms.DataGridView();
            this.parentsRequests = new System.Windows.Forms.DataGridView();
            this.pendingRequestsControl.SuspendLayout();
            this.staff.SuspendLayout();
            this.parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // pendingRequestsControl
            // 
            this.pendingRequestsControl.Controls.Add(this.staff);
            this.pendingRequestsControl.Controls.Add(this.parents);
            this.pendingRequestsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pendingRequestsControl.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.pendingRequestsControl.Location = new System.Drawing.Point(0, 0);
            this.pendingRequestsControl.Name = "pendingRequestsControl";
            this.pendingRequestsControl.Padding = new System.Drawing.Point(10, 10);
            this.pendingRequestsControl.SelectedIndex = 0;
            this.pendingRequestsControl.Size = new System.Drawing.Size(920, 540);
            this.pendingRequestsControl.TabIndex = 0;
            // 
            // staff
            // 
            this.staff.Controls.Add(this.staffRequests);
            this.staff.Location = new System.Drawing.Point(4, 53);
            this.staff.Name = "staff";
            this.staff.Padding = new System.Windows.Forms.Padding(3);
            this.staff.Size = new System.Drawing.Size(912, 483);
            this.staff.TabIndex = 0;
            this.staff.Text = "Staff";
            this.staff.UseVisualStyleBackColor = true;
            // 
            // parents
            // 
            this.parents.Controls.Add(this.parentsRequests);
            this.parents.Location = new System.Drawing.Point(4, 53);
            this.parents.Name = "parents";
            this.parents.Padding = new System.Windows.Forms.Padding(3);
            this.parents.Size = new System.Drawing.Size(912, 483);
            this.parents.TabIndex = 1;
            this.parents.Text = "Parents";
            this.parents.UseVisualStyleBackColor = true;
            // 
            // staffRequests
            // 
            this.staffRequests.AllowUserToOrderColumns = true;
            this.staffRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffRequests.Location = new System.Drawing.Point(3, 3);
            this.staffRequests.Name = "staffRequests";
            this.staffRequests.RowTemplate.Height = 24;
            this.staffRequests.Size = new System.Drawing.Size(906, 477);
            this.staffRequests.TabIndex = 0;
            // 
            // parentsRequests
            // 
            this.parentsRequests.AllowUserToOrderColumns = true;
            this.parentsRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentsRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentsRequests.Location = new System.Drawing.Point(3, 3);
            this.parentsRequests.Name = "parentsRequests";
            this.parentsRequests.RowTemplate.Height = 24;
            this.parentsRequests.Size = new System.Drawing.Size(906, 477);
            this.parentsRequests.TabIndex = 1;
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
            this.parents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl pendingRequestsControl;
        private System.Windows.Forms.TabPage staff;
        private System.Windows.Forms.TabPage parents;
        private System.Windows.Forms.DataGridView staffRequests;
        private System.Windows.Forms.DataGridView parentsRequests;
    }
}