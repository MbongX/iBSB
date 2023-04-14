namespace I_Bank___Student_Bank
{
    partial class CustomerRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtInitDeposit = new TextBox();
            label3 = new Label();
            btnRegister = new Button();
            rtbAccountDescription = new RichTextBox();
            label4 = new Label();
            cbAccountType = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 81);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Firstname :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 170);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Lastname :";
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstname.Location = new Point(170, 78);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(189, 23);
            txtFirstname.TabIndex = 2;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastname.Location = new Point(170, 167);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(189, 23);
            txtLastname.TabIndex = 3;
            // 
            // txtInitDeposit
            // 
            txtInitDeposit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtInitDeposit.Location = new Point(170, 252);
            txtInitDeposit.Name = "txtInitDeposit";
            txtInitDeposit.Size = new Size(189, 23);
            txtInitDeposit.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 255);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "Initial Deposit : ";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(473, 234);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(304, 41);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // rtbAccountDescription
            // 
            rtbAccountDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rtbAccountDescription.Location = new Point(473, 127);
            rtbAccountDescription.Name = "rtbAccountDescription";
            rtbAccountDescription.Size = new Size(304, 91);
            rtbAccountDescription.TabIndex = 7;
            rtbAccountDescription.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(471, 81);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 8;
            label4.Text = "Account Type : ";
            // 
            // cbAccountType
            // 
            cbAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAccountType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(565, 78);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(212, 23);
            cbAccountType.TabIndex = 9;
            cbAccountType.SelectedIndexChanged += cbAccountType_SelectedIndexChanged;
            // 
            // CustomerRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 336);
            Controls.Add(cbAccountType);
            Controls.Add(label4);
            Controls.Add(rtbAccountDescription);
            Controls.Add(btnRegister);
            Controls.Add(txtInitDeposit);
            Controls.Add(label3);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerRegistration";
            Text = "Customer Registration";
            Load += CustomerRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtInitDeposit;
        private Label label3;
        private Button btnRegister;
        private RichTextBox rtbAccountDescription;
        private Label label4;
        private ComboBox cbAccountType;
    }
}