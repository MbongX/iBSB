namespace I_Bank___Student_Bank
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btnCustomer = new Button();
            btniBSBEmpLogin = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            registrationToolStripMenuItem = new ToolStripMenuItem();
            mtsRegCustomer = new ToolStripMenuItem();
            mtsRegiBSBEmp = new ToolStripMenuItem();
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
            btniBSBEmpReg = new Button();
            btnCustLogin = new Button();
            gpCustomer = new GroupBox();
            groupBox1 = new GroupBox();
            menuStrip1.SuspendLayout();
            gpCustomer.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomer.Location = new Point(51, 53);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(220, 49);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Register";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btniBSBEmpLogin
            // 
            btniBSBEmpLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btniBSBEmpLogin.Location = new Point(60, 130);
            btniBSBEmpLogin.Name = "btniBSBEmpLogin";
            btniBSBEmpLogin.Size = new Size(220, 49);
            btniBSBEmpLogin.TabIndex = 1;
            btniBSBEmpLogin.Text = "Login";
            btniBSBEmpLogin.UseVisualStyleBackColor = true;
            btniBSBEmpLogin.Click += btniBSBEmp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, 46);
            label1.Name = "label1";
            label1.Size = new Size(581, 25);
            label1.TabIndex = 2;
            label1.Text = "Please select whether you are a \"Customer\" or an \"iBSB Employee\"";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, editToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
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
            registrationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mtsRegCustomer, mtsRegiBSBEmp });
            registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            registrationToolStripMenuItem.Size = new Size(137, 22);
            registrationToolStripMenuItem.Text = "Registration";
            // 
            // mtsRegCustomer
            // 
            mtsRegCustomer.Name = "mtsRegCustomer";
            mtsRegCustomer.Size = new Size(152, 22);
            mtsRegCustomer.Text = "Customer";
            mtsRegCustomer.Click += mtsRegCustomer_Click;
            // 
            // mtsRegiBSBEmp
            // 
            mtsRegiBSBEmp.Name = "mtsRegiBSBEmp";
            mtsRegiBSBEmp.Size = new Size(152, 22);
            mtsRegiBSBEmp.Text = "iBSB Employee";
            mtsRegiBSBEmp.Click += mtsRegiBSBEmp_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mtsLoginCustomer, mtsLoginiBSBEmp });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(137, 22);
            loginToolStripMenuItem.Text = "Login";
            // 
            // mtsLoginCustomer
            // 
            mtsLoginCustomer.Name = "mtsLoginCustomer";
            mtsLoginCustomer.Size = new Size(152, 22);
            mtsLoginCustomer.Text = "Customer";
            mtsLoginCustomer.Click += mtsLoginCustomer_Click;
            // 
            // mtsLoginiBSBEmp
            // 
            mtsLoginiBSBEmp.Name = "mtsLoginiBSBEmp";
            mtsLoginiBSBEmp.Size = new Size(152, 22);
            mtsLoginiBSBEmp.Text = "iBSB Employee";
            mtsLoginiBSBEmp.Click += mtsLoginiBSBEmp_Click;
            // 
            // mtsExit
            // 
            mtsExit.Name = "mtsExit";
            mtsExit.Size = new Size(137, 22);
            mtsExit.Text = "Exit";
            mtsExit.Click += mtsExit_Click;
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
            aboutUsToolStripMenuItem.Click += aboutUsToolStripMenuItem_Click;
            // 
            // moreInfoToolStripMenuItem
            // 
            moreInfoToolStripMenuItem.Name = "moreInfoToolStripMenuItem";
            moreInfoToolStripMenuItem.Size = new Size(126, 22);
            moreInfoToolStripMenuItem.Text = "More Info";
            // 
            // btniBSBEmpReg
            // 
            btniBSBEmpReg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btniBSBEmpReg.Location = new Point(60, 53);
            btniBSBEmpReg.Name = "btniBSBEmpReg";
            btniBSBEmpReg.Size = new Size(220, 49);
            btniBSBEmpReg.TabIndex = 5;
            btniBSBEmpReg.Text = "Register";
            btniBSBEmpReg.UseVisualStyleBackColor = true;
            btniBSBEmpReg.Click += btniBSBEmpReg_Click;
            // 
            // btnCustLogin
            // 
            btnCustLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustLogin.Location = new Point(51, 130);
            btnCustLogin.Name = "btnCustLogin";
            btnCustLogin.Size = new Size(220, 49);
            btnCustLogin.TabIndex = 4;
            btnCustLogin.Text = "Login";
            btnCustLogin.UseVisualStyleBackColor = true;
            btnCustLogin.Click += btnCustLogin_Click;
            // 
            // gpCustomer
            // 
            gpCustomer.Controls.Add(btnCustomer);
            gpCustomer.Controls.Add(btnCustLogin);
            gpCustomer.Location = new Point(49, 127);
            gpCustomer.Name = "gpCustomer";
            gpCustomer.Size = new Size(335, 225);
            gpCustomer.TabIndex = 6;
            gpCustomer.TabStop = false;
            gpCustomer.Text = "Customer";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btniBSBEmpLogin);
            groupBox1.Controls.Add(btniBSBEmpReg);
            groupBox1.Location = new Point(415, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 225);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "iBSB Employees";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(gpCustomer);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "iBank - Student Bank";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            gpCustomer.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCustomer;
        private Button btniBSBEmpLogin;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem registrationToolStripMenuItem;
        private ToolStripMenuItem mtsRegCustomer;
        private ToolStripMenuItem mtsRegiBSBEmp;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem mtsLoginCustomer;
        private ToolStripMenuItem mtsLoginiBSBEmp;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem moreInfoToolStripMenuItem;
        private ToolStripMenuItem mtsExit;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem darkToolStripMenuItem;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private Button btniBSBEmpReg;
        private Button btnCustLogin;
        private GroupBox gpCustomer;
        private GroupBox groupBox1;
    }
}