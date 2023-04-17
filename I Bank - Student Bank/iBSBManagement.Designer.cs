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
            // iBSBManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvReportSummary);
            Controls.Add(lblReportingFooter);
            Controls.Add(lblReportHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "iBSBManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "iBSBManagement";
            Load += iBSBManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReportHeading;
        private Label lblReportingFooter;
        private ListView lvReportSummary;
    }
}