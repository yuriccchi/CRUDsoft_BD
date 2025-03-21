namespace ViewTree
{
    partial class PlantForm
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
            label2 = new Label();
            cmbFamily = new ComboBox();
            btnSave = new Button();
            label1 = new Label();
            txtSpeciesName = new TextBox();
            cmbSpecies = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 28);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 13;
            label2.Text = "Family";
            // 
            // cmbFamily
            // 
            cmbFamily.FormattingEnabled = true;
            cmbFamily.Location = new Point(60, 25);
            cmbFamily.Name = "cmbFamily";
            cmbFamily.Size = new Size(248, 23);
            cmbFamily.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(234, 147);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 10;
            label1.Text = "Species";
            // 
            // txtSpeciesName
            // 
            txtSpeciesName.Location = new Point(11, 117);
            txtSpeciesName.Name = "txtSpeciesName";
            txtSpeciesName.Size = new Size(297, 23);
            txtSpeciesName.TabIndex = 9;
            // 
            // cmbSpecies
            // 
            cmbSpecies.FormattingEnabled = true;
            cmbSpecies.Location = new Point(60, 63);
            cmbSpecies.Name = "cmbSpecies";
            cmbSpecies.Size = new Size(248, 23);
            cmbSpecies.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 15;
            label3.Text = "Name of Plant";
            // 
            // PlantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 182);
            Controls.Add(label3);
            Controls.Add(cmbSpecies);
            Controls.Add(label2);
            Controls.Add(cmbFamily);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtSpeciesName);
            Name = "PlantForm";
            Text = "PlantForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cmbFamily;
        private Button btnSave;
        private Label label1;
        private TextBox txtSpeciesName;
        private ComboBox cmbSpecies;
        private Label label3;
    }
}