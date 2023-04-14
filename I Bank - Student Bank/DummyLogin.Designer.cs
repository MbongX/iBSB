namespace I_Bank___Student_Bank
{
    partial class DummyLogin
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
            lblReportHeading = new Label();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblReportHeading
            // 
            lblReportHeading.AutoSize = true;
            lblReportHeading.Font = new Font("Segoe UI", 17F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblReportHeading.Location = new Point(187, 9);
            lblReportHeading.Name = "lblReportHeading";
            lblReportHeading.Size = new Size(241, 31);
            lblReportHeading.TabIndex = 1;
            lblReportHeading.Text = "iBSB Employee Login";
            lblReportHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 68);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 2;
            label1.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 127);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 3;
            label2.Text = "Password :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(148, 67);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(246, 23);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(148, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(246, 23);
            txtPassword.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(431, 81);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 45);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login ";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // DummyLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 186);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblReportHeading);
            Name = "DummyLogin";
            Text = "DummyLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReportHeading;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
    }
}