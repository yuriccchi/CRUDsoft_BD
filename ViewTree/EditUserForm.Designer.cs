namespace ViewTree
{
    partial class EditUserForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUserName = new TextBox();
            txtActPass = new TextBox();
            txtNewPass = new TextBox();
            btnConfirm = new Button();
            chkIsAdmin = new CheckBox();
            chkIsActive = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(71, 33);
            label2.TabIndex = 1;
            label2.Text = "Actual password";
            // 
            // label3
            // 
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(62, 30);
            label3.TabIndex = 2;
            label3.Text = "New password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Admin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 231);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 4;
            label5.Text = "Active";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(80, 36);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(192, 23);
            txtUserName.TabIndex = 5;
            // 
            // txtActPass
            // 
            txtActPass.Location = new Point(80, 84);
            txtActPass.Name = "txtActPass";
            txtActPass.Size = new Size(192, 23);
            txtActPass.TabIndex = 6;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(80, 136);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(192, 23);
            txtNewPass.TabIndex = 7;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(197, 276);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 10;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // chkIsAdmin
            // 
            chkIsAdmin.AutoSize = true;
            chkIsAdmin.Location = new Point(80, 185);
            chkIsAdmin.Name = "chkIsAdmin";
            chkIsAdmin.Size = new Size(40, 19);
            chkIsAdmin.TabIndex = 11;
            chkIsAdmin.Text = "Да";
            chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(80, 230);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(40, 19);
            chkIsActive.TabIndex = 12;
            chkIsActive.Text = "Да";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 311);
            Controls.Add(chkIsActive);
            Controls.Add(chkIsAdmin);
            Controls.Add(btnConfirm);
            Controls.Add(txtNewPass);
            Controls.Add(txtActPass);
            Controls.Add(txtUserName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditUserForm";
            Text = "EditUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUserName;
        private TextBox txtActPass;
        private TextBox txtNewPass;
        private Button btnConfirm;
        private CheckBox chkIsAdmin;
        private CheckBox chkIsActive;
    }
}