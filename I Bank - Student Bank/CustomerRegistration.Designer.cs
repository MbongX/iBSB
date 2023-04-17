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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRegistration));
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
            lblReportHeading = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            registrationToolStripMenuItem = new ToolStripMenuItem();
            mtsRegCustomer = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            mtsLoginCustomer = new ToolStripMenuItem();
            mtsLoginiBSBEmp = new ToolStripMenuItem();
            mtsExit = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            moreInfoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 112);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Firstname :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 201);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Lastname :";
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstname.Location = new Point(170, 109);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(189, 23);
            txtFirstname.TabIndex = 2;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastname.Location = new Point(170, 198);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(189, 23);
            txtLastname.TabIndex = 3;
            // 
            // txtInitDeposit
            // 
            txtInitDeposit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtInitDeposit.Location = new Point(170, 283);
            txtInitDeposit.Name = "txtInitDeposit";
            txtInitDeposit.Size = new Size(189, 23);
            txtInitDeposit.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 286);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "Initial Deposit : ";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(473, 265);
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
            rtbAccountDescription.Location = new Point(473, 158);
            rtbAccountDescription.Name = "rtbAccountDescription";
            rtbAccountDescription.Size = new Size(304, 91);
            rtbAccountDescription.TabIndex = 7;
            rtbAccountDescription.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(471, 112);
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
            cbAccountType.Location = new Point(565, 109);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(212, 23);
            cbAccountType.TabIndex = 9;
            cbAccountType.SelectedIndexChanged += cbAccountType_SelectedIndexChanged;
            // 
            // lblReportHeading
            // 
            lblReportHeading.AutoSize = true;
            lblReportHeading.Font = new Font("Segoe UI", 17F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblReportHeading.Location = new Point(293, 41);
            lblReportHeading.Name = "lblReportHeading";
            lblReportHeading.Size = new Size(241, 31);
            lblReportHeading.TabIndex = 10;
            lblReportHeading.Text = "iBSB Employee Login";
            lblReportHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, editToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(841, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrationToolStripMenuItem, loginToolStripMenuItem, mtsExit });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // registrationToolStripMenuItem
            // 
            registrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mtsRegCustomer });
            registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            registrationToolStripMenuItem.Size = new Size(180, 22);
            registrationToolStripMenuItem.Text = "Registration";
            // 
            // mtsRegCustomer
            // 
            mtsRegCustomer.Name = "mtsRegCustomer";
            mtsRegCustomer.Size = new Size(180, 22);
            mtsRegCustomer.Text = "Customer";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mtsLoginCustomer, mtsLoginiBSBEmp });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(180, 22);
            loginToolStripMenuItem.Text = "Login";
            // 
            // mtsLoginCustomer
            // 
            mtsLoginCustomer.Name = "mtsLoginCustomer";
            mtsLoginCustomer.Size = new Size(152, 22);
            mtsLoginCustomer.Text = "Customer";
            // 
            // mtsLoginiBSBEmp
            // 
            mtsLoginiBSBEmp.Name = "mtsLoginiBSBEmp";
            mtsLoginiBSBEmp.Size = new Size(152, 22);
            mtsLoginiBSBEmp.Text = "iBSB Employee";
            // 
            // mtsExit
            // 
            mtsExit.Name = "mtsExit";
            mtsExit.Size = new Size(180, 22);
            mtsExit.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { themeToolStripMenuItem, fontToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkToolStripMenuItem, lightToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(110, 22);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(101, 22);
            darkToolStripMenuItem.Text = "Dark";
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(101, 22);
            lightToolStripMenuItem.Text = "Light";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(110, 22);
            fontToolStripMenuItem.Text = "Font";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutUsToolStripMenuItem, moreInfoToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(126, 22);
            aboutUsToolStripMenuItem.Text = "About us";
            // 
            // moreInfoToolStripMenuItem
            // 
            moreInfoToolStripMenuItem.Name = "moreInfoToolStripMenuItem";
            moreInfoToolStripMenuItem.Size = new Size(126, 22);
            moreInfoToolStripMenuItem.Text = "More Info";
            // 
            // CustomerRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 336);
            Controls.Add(menuStrip1);
            Controls.Add(lblReportHeading);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CustomerRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Registration";
            Load += CustomerRegistration_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Label lblReportHeading;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem mtsExit;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem moreInfoToolStripMenuItem;
        private ToolStripMenuItem registrationToolStripMenuItem;
        private ToolStripMenuItem mtsRegCustomer;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem mtsLoginCustomer;
        private ToolStripMenuItem mtsLoginiBSBEmp;
    }
}