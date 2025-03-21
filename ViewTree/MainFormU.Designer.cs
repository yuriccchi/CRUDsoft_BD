namespace ViewTree
{
    partial class MainFormU
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
            components = new System.ComponentModel.Container();
            contextMenuStrip = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            btnAddUser = new Button();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listUsers = new ListView();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.Size = new Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(107, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(312, 12);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(100, 23);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add user";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "User";
            columnHeader1.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Admin";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Active";
            columnHeader4.Width = 100;
            // 
            // listUsers
            // 
            listUsers.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader3, columnHeader4 });
            listUsers.GridLines = true;
            listUsers.HideSelection = true;
            listUsers.Location = new Point(12, 41);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(405, 397);
            listUsers.TabIndex = 0;
            listUsers.UseCompatibleStateImageBehavior = false;
            listUsers.View = View.Details;
            // 
            // MainFormU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 450);
            Controls.Add(btnAddUser);
            Controls.Add(listUsers);
            Name = "MainFormU";
            Text = "Users";
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Button btnAddUser;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listUsers;
    }
}