namespace ViewTree
{
    partial class SpeciesForm
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
            txtSpeciesName = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            cmbFamily = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtSpeciesName
            // 
            txtSpeciesName.Location = new Point(12, 86);
            txtSpeciesName.Name = "txtSpeciesName";
            txtSpeciesName.Size = new Size(297, 23);
            txtSpeciesName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 4;
            label1.Text = "Name of Species";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(233, 127);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbFamily
            // 
            cmbFamily.FormattingEnabled = true;
            cmbFamily.Location = new Point(60, 22);
            cmbFamily.Name = "cmbFamily";
            cmbFamily.Size = new Size(248, 23);
            cmbFamily.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 25);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 8;
            label2.Text = "Family";
            // 
            // SpeciesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 161);
            Controls.Add(label2);
            Controls.Add(cmbFamily);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtSpeciesName);
            Name = "SpeciesForm";
            Text = "SpeciesForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSpeciesName;
        private Label label1;
        private Button btnSave;
        private ComboBox cmbFamily;
        private Label label2;
    }
}