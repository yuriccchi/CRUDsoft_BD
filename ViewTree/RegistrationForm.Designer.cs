namespace ViewTree
{
    partial class RegistrationForm
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnRegistration = new Button();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(78, 19);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(194, 23);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(78, 52);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(194, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnRegistration
            // 
            btnRegistration.Location = new Point(156, 126);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(116, 23);
            btnRegistration.TabIndex = 4;
            btnRegistration.Text = "Registration";
            btnRegistration.UseVisualStyleBackColor = true;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // label3
            // 
            label3.Location = new Point(12, 87);
            label3.Name = "label3";
            label3.Size = new Size(57, 34);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(78, 87);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(194, 23);
            txtConfirmPassword.TabIndex = 6;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 161);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label3);
            Controls.Add(btnRegistration);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Button btnRegistration;
        private Label label3;
        private TextBox txtConfirmPassword;
    }
}