namespace Nursery_Management_System
{
    partial class editDatabase
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
            this.editDatabaseControl = new System.Windows.Forms.TabControl();
            this.staff = new System.Windows.Forms.TabPage();
            this.parents = new System.Windows.Forms.TabPage();
            this.children = new System.Windows.Forms.TabPage();
            this.editDatabaseControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // editDatabaseControl
            // 
            this.editDatabaseControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.editDatabaseControl.Controls.Add(this.staff);
            this.editDatabaseControl.Controls.Add(this.parents);
            this.editDatabaseControl.Controls.Add(this.children);
            this.editDatabaseControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editDatabaseControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.editDatabaseControl.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.editDatabaseControl.Location = new System.Drawing.Point(0, 0);
            this.editDatabaseControl.Name = "editDatabaseControl";
            this.editDatabaseControl.Padding = new System.Drawing.Point(10, 10);
            this.editDatabaseControl.SelectedIndex = 0;
            this.editDatabaseControl.Size = new System.Drawing.Size(920, 540);
            this.editDatabaseControl.TabIndex = 0;
            // 
            // staff
            // 
            this.staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            this.staff.Location = new System.Drawing.Point(4, 56);
            this.staff.Name = "staff";
            this.staff.Padding = new System.Windows.Forms.Padding(3);
            this.staff.Size = new System.Drawing.Size(912, 480);
            this.staff.TabIndex = 0;
            this.staff.Text = "Staff";
            // 
            // parents
            // 
            this.parents.Location = new System.Drawing.Point(4, 56);
            this.parents.Name = "parents";
            this.parents.Padding = new System.Windows.Forms.Padding(3);
            this.parents.Size = new System.Drawing.Size(912, 480);
            this.parents.TabIndex = 1;
            this.parents.Text = "Parents";
            this.parents.UseVisualStyleBackColor = true;
            // 
            // children
            // 
            this.children.Location = new System.Drawing.Point(4, 56);
            this.children.Name = "children";
            this.children.Padding = new System.Windows.Forms.Padding(3);
            this.children.Size = new System.Drawing.Size(912, 480);
            this.children.TabIndex = 2;
            this.children.Text = "Children";
            this.children.UseVisualStyleBackColor = true;
            // 
            // editDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.editDatabaseControl);
            this.Name = "editDatabase";
            this.Text = "Edit_Database";
            this.Load += new System.EventHandler(this.editDatabase_Load);
            this.editDatabaseControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl editDatabaseControl;
        private System.Windows.Forms.TabPage staff;
        private System.Windows.Forms.TabPage parents;
        private System.Windows.Forms.TabPage children;
    }
}