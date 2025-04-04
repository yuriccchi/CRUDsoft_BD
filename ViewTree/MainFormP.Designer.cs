namespace ViewTree
{
    partial class MainFormP
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
            trvPlants = new TreeView();
            btnLoadData = new Button();
            FamilyContextMenu = new ContextMenuStrip(components);
            addFamilyToolStripMenuItem = new ToolStripMenuItem();
            editFamilyToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            deleteFamilyToolStripMenuItem = new ToolStripMenuItem();
            SpeciesContextMenu = new ContextMenuStrip(components);
            addSpeciesToolStripMenuItem = new ToolStripMenuItem();
            editSpeciesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            deleteSpeciesToolStripMenuItem = new ToolStripMenuItem();
            PlantContextMenu = new ContextMenuStrip(components);
            addPlantToolStripMenuItem = new ToolStripMenuItem();
            editPlantToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            deletePlantToolStripMenuItem = new ToolStripMenuItem();
            FamilyContextMenu.SuspendLayout();
            SpeciesContextMenu.SuspendLayout();
            PlantContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // trvPlants
            // 
            trvPlants.AllowDrop = true;
            trvPlants.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trvPlants.HideSelection = false;
            trvPlants.LabelEdit = true;
            trvPlants.Location = new Point(12, 73);
            trvPlants.Name = "trvPlants";
            trvPlants.ShowNodeToolTips = true;
            trvPlants.Size = new Size(560, 376);
            trvPlants.TabIndex = 1;
            // 
            // btnLoadData
            // 
            btnLoadData.AccessibleRole = AccessibleRole.None;
            btnLoadData.BackColor = Color.FromArgb(169, 194, 175);
            btnLoadData.Font = new Font("Segoe UI", 24F);
            btnLoadData.Location = new Point(12, 12);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(278, 55);
            btnLoadData.TabIndex = 2;
            btnLoadData.Text = "Plants Database";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // FamilyContextMenu
            // 
            FamilyContextMenu.Items.AddRange(new ToolStripItem[] { addFamilyToolStripMenuItem, editFamilyToolStripMenuItem, toolStripSeparator1, deleteFamilyToolStripMenuItem });
            FamilyContextMenu.Name = "FamilyContextMenu";
            FamilyContextMenu.Size = new Size(133, 76);
            // 
            // addFamilyToolStripMenuItem
            // 
            addFamilyToolStripMenuItem.Name = "addFamilyToolStripMenuItem";
            addFamilyToolStripMenuItem.Size = new Size(132, 22);
            addFamilyToolStripMenuItem.Text = "Add family";
            addFamilyToolStripMenuItem.Click += addFamilyToolStripMenuItem_Click;
            // 
            // editFamilyToolStripMenuItem
            // 
            editFamilyToolStripMenuItem.Name = "editFamilyToolStripMenuItem";
            editFamilyToolStripMenuItem.Size = new Size(132, 22);
            editFamilyToolStripMenuItem.Text = "Edit";
            editFamilyToolStripMenuItem.Click += editFamilyToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(129, 6);
            // 
            // deleteFamilyToolStripMenuItem
            // 
            deleteFamilyToolStripMenuItem.Name = "deleteFamilyToolStripMenuItem";
            deleteFamilyToolStripMenuItem.Size = new Size(132, 22);
            deleteFamilyToolStripMenuItem.Text = "Delete";
            deleteFamilyToolStripMenuItem.Click += deleteFamilyToolStripMenuItem_Click;
            // 
            // SpeciesContextMenu
            // 
            SpeciesContextMenu.Items.AddRange(new ToolStripItem[] { addSpeciesToolStripMenuItem, editSpeciesToolStripMenuItem, toolStripSeparator2, deleteSpeciesToolStripMenuItem });
            SpeciesContextMenu.Name = "SpeciesContextMenu";
            SpeciesContextMenu.Size = new Size(138, 76);
            // 
            // addSpeciesToolStripMenuItem
            // 
            addSpeciesToolStripMenuItem.Name = "addSpeciesToolStripMenuItem";
            addSpeciesToolStripMenuItem.Size = new Size(137, 22);
            addSpeciesToolStripMenuItem.Text = "Add species";
            addSpeciesToolStripMenuItem.Click += addSpeciesToolStripMenuItem_Click;
            // 
            // editSpeciesToolStripMenuItem
            // 
            editSpeciesToolStripMenuItem.Name = "editSpeciesToolStripMenuItem";
            editSpeciesToolStripMenuItem.Size = new Size(137, 22);
            editSpeciesToolStripMenuItem.Text = "Edit";
            editSpeciesToolStripMenuItem.Click += editSpeciesToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(134, 6);
            // 
            // deleteSpeciesToolStripMenuItem
            // 
            deleteSpeciesToolStripMenuItem.Name = "deleteSpeciesToolStripMenuItem";
            deleteSpeciesToolStripMenuItem.Size = new Size(137, 22);
            deleteSpeciesToolStripMenuItem.Text = "Delete";
            deleteSpeciesToolStripMenuItem.Click += deleteSpeciesToolStripMenuItem_Click;
            // 
            // PlantContextMenu
            // 
            PlantContextMenu.Items.AddRange(new ToolStripItem[] { addPlantToolStripMenuItem, editPlantToolStripMenuItem, toolStripSeparator3, deletePlantToolStripMenuItem });
            PlantContextMenu.Name = "PlantContextMenu";
            PlantContextMenu.Size = new Size(127, 76);
            // 
            // addPlantToolStripMenuItem
            // 
            addPlantToolStripMenuItem.Name = "addPlantToolStripMenuItem";
            addPlantToolStripMenuItem.Size = new Size(126, 22);
            addPlantToolStripMenuItem.Text = "Add plant";
            addPlantToolStripMenuItem.Click += addPlantToolStripMenuItem_Click;
            // 
            // editPlantToolStripMenuItem
            // 
            editPlantToolStripMenuItem.Name = "editPlantToolStripMenuItem";
            editPlantToolStripMenuItem.Size = new Size(126, 22);
            editPlantToolStripMenuItem.Text = "Edit";
            editPlantToolStripMenuItem.Click += editPlantToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(123, 6);
            // 
            // deletePlantToolStripMenuItem
            // 
            deletePlantToolStripMenuItem.Name = "deletePlantToolStripMenuItem";
            deletePlantToolStripMenuItem.Size = new Size(126, 22);
            deletePlantToolStripMenuItem.Text = "Delete";
            deletePlantToolStripMenuItem.Click += deletePlantToolStripMenuItem_Click;
            // 
            // MainFormP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 194, 175);
            ClientSize = new Size(584, 461);
            Controls.Add(btnLoadData);
            Controls.Add(trvPlants);
            Name = "MainFormP";
            Text = "TreeView - Plants";
            FamilyContextMenu.ResumeLayout(false);
            SpeciesContextMenu.ResumeLayout(false);
            PlantContextMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TreeView trvPlants;
        private Button btnLoadData;
        private ContextMenuStrip FamilyContextMenu;
        private ToolStripMenuItem addFamilyToolStripMenuItem;
        private ToolStripMenuItem editFamilyToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem deleteFamilyToolStripMenuItem;
        private ContextMenuStrip SpeciesContextMenu;
        private ToolStripMenuItem addSpeciesToolStripMenuItem;
        private ToolStripMenuItem editSpeciesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem deleteSpeciesToolStripMenuItem;
        private ContextMenuStrip PlantContextMenu;
        private ToolStripMenuItem addPlantToolStripMenuItem;
        private ToolStripMenuItem editPlantToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem deletePlantToolStripMenuItem;
    }
}