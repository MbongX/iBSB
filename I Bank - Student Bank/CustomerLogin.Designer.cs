namespace I_Bank___Student_Bank
{
    partial class CustomerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLogin));
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblReportHeading = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(318, 180);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 45);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Login ";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(214, 136);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(246, 23);
            txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(214, 92);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(246, 23);
            txtUsername.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(131, 136);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 9;
            label2.Text = "Pin :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 90);
            label1.Name = "label1";
            label1.Size = new Size(148, 21);
            label1.TabIndex = 8;
            label1.Text = "Account Number :";
            // 
            // lblReportHeading
            // 
            lblReportHeading.AutoSize = true;
            lblReportHeading.Font = new Font("Segoe UI", 17F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblReportHeading.Location = new Point(168, 33);
            lblReportHeading.Name = "lblReportHeading";
            lblReportHeading.Size = new Size(184, 31);
            lblReportHeading.TabIndex = 7;
            lblReportHeading.Text = "Customer Login";
            lblReportHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 256);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblReportHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Label lblReportHeading;
    }
}