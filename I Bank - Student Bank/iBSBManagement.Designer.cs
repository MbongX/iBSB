namespace I_Bank___Student_Bank
{
    partial class iBSBManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iBSBManagement));
            lblReportHeading = new Label();
            lblReportingFooter = new Label();
            lvReportSummary = new ListView();
            ReportMenuStrip = new MenuStrip();
            TransactionMenu = new ToolStripMenuItem();
            logOutReportMenu = new ToolStripMenuItem();
            exitReportMenu = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            darkReportMenu = new ToolStripMenuItem();
            lightToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutUsReportMenu = new ToolStripMenuItem();
            moreInfoToolStripMenuItem = new ToolStripMenuItem();
            ReportMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lblReportHeading
            // 
            lblReportHeading.AutoSize = true;
            lblReportHeading.Font = new Font("Segoe UI", 17F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblReportHeading.Location = new Point(244, 38);
            lblReportHeading.Name = "lblReportHeading";
            lblReportHeading.Size = new Size(266, 31);
            lblReportHeading.TabIndex = 0;
            lblReportHeading.Text = "[Date] + [Report Name]";
            lblReportHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblReportingFooter
            // 
            lblReportingFooter.AutoSize = true;
            lblReportingFooter.Location = new Point(17, 401);
            lblReportingFooter.Name = "lblReportingFooter";
            lblReportingFooter.Size = new Size(104, 15);
            lblReportingFooter.TabIndex = 2;
            lblReportingFooter.Text = "[Reporting Footer]";
            // 
            // lvReportSummary
            // 
            lvReportSummary.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lvReportSummary.Location = new Point(28, 108);
            lvReportSummary.Name = "lvReportSummary";
            lvReportSummary.Size = new Size(736, 277);
            lvReportSummary.TabIndex = 3;
            lvReportSummary.UseCompatibleStateImageBehavior = false;
            // 
            // ReportMenuStrip
            // 
            ReportMenuStrip.Items.AddRange(new ToolStripItem[] { TransactionMenu, editToolStripMenuItem, aboutToolStripMenuItem });
            ReportMenuStrip.Location = new Point(0, 0);
            ReportMenuStrip.Name = "ReportMenuStrip";
            ReportMenuStrip.Size = new Size(800, 24);
            ReportMenuStrip.TabIndex = 6;
            ReportMenuStrip.Text = "menuStrip1";
            // 
            // TransactionMenu
            // 
            TransactionMenu.DropDownItems.AddRange(new ToolStripItem[] { logOutReportMenu, exitReportMenu });
            TransactionMenu.Name = "TransactionMenu";
            TransactionMenu.Size = new Size(50, 20);
            TransactionMenu.Text = "Menu";
            // 
            // logOutReportMenu
            // 
            logOutReportMenu.Name = "logOutReportMenu";
            logOutReportMenu.Size = new Size(180, 22);
            logOutReportMenu.Text = "Log out";
            // 
            // exitReportMenu
            // 
            exitReportMenu.Name = "exitReportMenu";
            exitReportMenu.Size = new Size(180, 22);
            exitReportMenu.Text = "Exit";
            exitReportMenu.Click += exitReportMenu_Click;
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
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { darkReportMenu, lightToolStripMenuItem });
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(110, 22);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // darkReportMenu
            // 
            darkReportMenu.Name = "darkReportMenu";
            darkReportMenu.Size = new Size(101, 22);
            darkReportMenu.Text = "Dark";
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
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutUsReportMenu, moreInfoToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutUsReportMenu
            // 
            aboutUsReportMenu.Name = "aboutUsReportMenu";
            aboutUsReportMenu.Size = new Size(180, 22);
            aboutUsReportMenu.Text = "About us";
            aboutUsReportMenu.Click += aboutUsReportMenu_Click;
            // 
            // moreInfoToolStripMenuItem
            // 
            moreInfoToolStripMenuItem.Name = "moreInfoToolStripMenuItem";
            moreInfoToolStripMenuItem.Size = new Size(180, 22);
            moreInfoToolStripMenuItem.Text = "More Info";
            // 
            // iBSBManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReportMenuStrip);
            Controls.Add(lvReportSummary);
            Controls.Add(lblReportingFooter);
            Controls.Add(lblReportHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "iBSBManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "iBSBManagement";
            Load += iBSBManagement_Load;
            ReportMenuStrip.ResumeLayout(false);
            ReportMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReportHeading;
        private Label lblReportingFooter;
        private ListView lvReportSummary;
        private MenuStrip ReportMenuStrip;
        private ToolStripMenuItem TransactionMenu;
        private ToolStripMenuItem logOutReportMenu;
        private ToolStripMenuItem exitReportMenu;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem darkReportMenu;
        private ToolStripMenuItem lightToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutUsReportMenu;
        private ToolStripMenuItem moreInfoToolStripMenuItem;
    }
}