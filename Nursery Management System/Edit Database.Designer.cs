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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.children = new System.Windows.Forms.TabPage();
            this.childrenTable = new System.Windows.Forms.DataGridView();
            this.parents = new System.Windows.Forms.TabPage();
            this.parentsTable = new System.Windows.Forms.DataGridView();
            this.staff = new System.Windows.Forms.TabPage();
            this.staffTable = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editDatabaseControl = new System.Windows.Forms.TabControl();
            this.staffTableView = new System.Windows.Forms.DataGridView();
            this.rooms = new System.Windows.Forms.TabPage();
            this.roomsTable = new System.Windows.Forms.DataGridView();
            this.children.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.childrenTable)).BeginInit();
            this.parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parentsTable)).BeginInit();
            this.staff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffTable)).BeginInit();
            this.editDatabaseControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffTableView)).BeginInit();
            this.rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // children
            // 
            this.children.Controls.Add(this.childrenTable);
            this.children.Location = new System.Drawing.Point(4, 56);
            this.children.Name = "children";
            this.children.Padding = new System.Windows.Forms.Padding(3);
            this.children.Size = new System.Drawing.Size(912, 480);
            this.children.TabIndex = 2;
            this.children.Text = "Children";
            this.children.UseVisualStyleBackColor = true;
            // 
            // childrenTable
            // 
            this.childrenTable.AllowUserToOrderColumns = true;
            this.childrenTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childrenTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childrenTable.Location = new System.Drawing.Point(3, 3);
            this.childrenTable.Name = "childrenTable";
            this.childrenTable.RowTemplate.Height = 24;
            this.childrenTable.Size = new System.Drawing.Size(906, 474);
            this.childrenTable.TabIndex = 0;
            // 
            // parents
            // 
            this.parents.Controls.Add(this.parentsTable);
            this.parents.Location = new System.Drawing.Point(4, 56);
            this.parents.Name = "parents";
            this.parents.Padding = new System.Windows.Forms.Padding(3);
            this.parents.Size = new System.Drawing.Size(912, 480);
            this.parents.TabIndex = 1;
            this.parents.Text = "Parents";
            this.parents.UseVisualStyleBackColor = true;
            // 
            // parentsTable
            // 
            this.parentsTable.AllowUserToOrderColumns = true;
            this.parentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parentsTable.Location = new System.Drawing.Point(3, 3);
            this.parentsTable.Name = "parentsTable";
            this.parentsTable.RowTemplate.Height = 24;
            this.parentsTable.Size = new System.Drawing.Size(906, 474);
            this.parentsTable.TabIndex = 0;
            // 
            // staff
            // 
            this.staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            this.staff.Controls.Add(this.staffTable);
            this.staff.Location = new System.Drawing.Point(4, 56);
            this.staff.Name = "staff";
            this.staff.Padding = new System.Windows.Forms.Padding(3);
            this.staff.Size = new System.Drawing.Size(912, 480);
            this.staff.TabIndex = 0;
            this.staff.Text = "Staff";
            // 
            // staffTable
            // 
            this.staffTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            this.staffTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.phoneNumber,
            this.email,
            this.salary});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bebas Neue", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.staffTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.staffTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            this.staffTable.Location = new System.Drawing.Point(3, 3);
            this.staffTable.Name = "staffTable";
            this.staffTable.RowTemplate.Height = 24;
            this.staffTable.Size = new System.Drawing.Size(906, 474);
            this.staffTable.TabIndex = 0;
            this.staffTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.Name = "phoneNumber";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // salary
            // 
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            // 
            // editDatabaseControl
            // 
            this.editDatabaseControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.editDatabaseControl.Controls.Add(this.staff);
            this.editDatabaseControl.Controls.Add(this.parents);
            this.editDatabaseControl.Controls.Add(this.children);
            this.editDatabaseControl.Controls.Add(this.rooms);
            this.editDatabaseControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editDatabaseControl.Font = new System.Drawing.Font("Bebas Neue", 15F);
            this.editDatabaseControl.Location = new System.Drawing.Point(0, 0);
            this.editDatabaseControl.Name = "editDatabaseControl";
            this.editDatabaseControl.Padding = new System.Drawing.Point(10, 10);
            this.editDatabaseControl.SelectedIndex = 0;
            this.editDatabaseControl.Size = new System.Drawing.Size(920, 540);
            this.editDatabaseControl.TabIndex = 0;
            // 
            // staffTableView
            // 
            this.staffTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffTableView.Location = new System.Drawing.Point(8, 8);
            this.staffTableView.Name = "staffTableView";
            this.staffTableView.RowTemplate.Height = 24;
            this.staffTableView.Size = new System.Drawing.Size(240, 150);
            this.staffTableView.TabIndex = 0;
            this.staffTableView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rooms
            // 
            this.rooms.Controls.Add(this.roomsTable);
            this.rooms.Location = new System.Drawing.Point(4, 56);
            this.rooms.Name = "rooms";
            this.rooms.Padding = new System.Windows.Forms.Padding(3);
            this.rooms.Size = new System.Drawing.Size(912, 480);
            this.rooms.TabIndex = 3;
            this.rooms.Text = "Rooms";
            this.rooms.UseVisualStyleBackColor = true;
            // 
            // roomsTable
            // 
            this.roomsTable.AllowUserToOrderColumns = true;
            this.roomsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomsTable.Location = new System.Drawing.Point(3, 3);
            this.roomsTable.Name = "roomsTable";
            this.roomsTable.RowTemplate.Height = 24;
            this.roomsTable.Size = new System.Drawing.Size(906, 474);
            this.roomsTable.TabIndex = 0;
            // 
            // editDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(220)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(920, 540);
            this.Controls.Add(this.editDatabaseControl);
            this.Name = "editDatabase";
            this.Text = "Nursery Management System - Edit Database";
            this.Load += new System.EventHandler(this.editDatabase_Load);
            this.children.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.childrenTable)).EndInit();
            this.parents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parentsTable)).EndInit();
            this.staff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffTable)).EndInit();
            this.editDatabaseControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffTableView)).EndInit();
            this.rooms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roomsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl editDatabaseControl;
        private System.Windows.Forms.TabPage staff;
        private System.Windows.Forms.TabPage parents;
        private System.Windows.Forms.TabPage children;
        private System.Windows.Forms.DataGridView staffTable;
        private System.Windows.Forms.DataGridView staffTableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridView childrenTable;
        private System.Windows.Forms.DataGridView parentsTable;
        private System.Windows.Forms.TabPage rooms;
        private System.Windows.Forms.DataGridView roomsTable;
    }
}