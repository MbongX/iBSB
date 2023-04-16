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
            btnCustomer = new Button();
            btniBSBEmp = new Button();
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
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            moreInfoToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            darkToolStripMenuItem = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomer.Location = new Point(73, 202);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(261, 117);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btniBSBEmp
            // 
            btniBSBEmp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btniBSBEmp.Location = new Point(461, 202);
            btniBSBEmp.Name = "btniBSBEmp";
            btniBSBEmp.Size = new Size(261, 117);
            btniBSBEmp.TabIndex = 1;
            btniBSBEmp.Text = "iBSB Employee";
            btniBSBEmp.UseVisualStyleBackColor = true;
            btniBSBEmp.Click += btniBSBEmp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(96, 101);
            label1.Name = "label1";
            label1.Size = new Size(581, 25);
            label1.TabIndex = 2;
            label1.Text = "Please select whether you are a \"Customer\" or an \"iBSB Employee\"";
            label1.Click += label1_Click;
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
            registrationToolStripMenuItem.Size = new Size(180, 22);
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
            loginToolStripMenuItem.Size = new Size(180, 22);
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
            mtsExit.Size = new Size(180, 22);
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
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkToolStripMenuItem, lightToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(180, 22);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            darkToolStripMenuItem.Size = new Size(180, 22);
            darkToolStripMenuItem.Text = "Dark";
            // 
            // lightToolStripMenuItem
            // 
            lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            lightToolStripMenuItem.Size = new Size(180, 22);
            lightToolStripMenuItem.Text = "Light";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(180, 22);
            fontToolStripMenuItem.Text = "Font";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btniBSBEmp);
            Controls.Add(btnCustomer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "Main";
            Text = "iBank - Student Bank";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCustomer;
        private Button btniBSBEmp;
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
    }
}