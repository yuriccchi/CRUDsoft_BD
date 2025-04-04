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
            btnSave = new Button();
            label1 = new Label();
            txtPlantName = new TextBox();
            cmbSpecies = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(234, 127);
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
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 10;
            label1.Text = "Species";
            // 
            // txtPlantName
            // 
            txtPlantName.Location = new Point(11, 86);
            txtPlantName.Name = "txtPlantName";
            txtPlantName.Size = new Size(297, 23);
            txtPlantName.TabIndex = 9;
            // 
            // cmbSpecies
            // 
            cmbSpecies.FormattingEnabled = true;
            cmbSpecies.Location = new Point(60, 22);
            cmbSpecies.Name = "cmbSpecies";
            cmbSpecies.Size = new Size(248, 23);
            cmbSpecies.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 15;
            label3.Text = "Name of Plant";
            // 
            // PlantForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 161);
            Controls.Add(label3);
            Controls.Add(cmbSpecies);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtPlantName);
            Name = "PlantForm";
            Text = "PlantForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private Label label1;
        private TextBox txtPlantName;
        private ComboBox cmbSpecies;
        private Label label3;
    }
}