namespace I_Bank___Student_Bank
{
    partial class CustomerTransaction
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
            btnDeposit = new Button();
            btnWithdraw = new Button();
            btnAccountStat = new Button();
            SuspendLayout();
            // 
            // btnDeposit
            // 
            btnDeposit.Location = new Point(170, 54);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(139, 55);
            btnDeposit.TabIndex = 0;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(362, 54);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(139, 55);
            btnWithdraw.TabIndex = 1;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnAccountStat
            // 
            btnAccountStat.Location = new Point(551, 54);
            btnAccountStat.Name = "btnAccountStat";
            btnAccountStat.Size = new Size(139, 55);
            btnAccountStat.TabIndex = 2;
            btnAccountStat.Text = "Account Statement";
            btnAccountStat.UseVisualStyleBackColor = true;
            btnAccountStat.Click += btnAccountStat_Click;
            // 
            // CustomerTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 491);
            Controls.Add(btnAccountStat);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Name = "CustomerTransaction";
            Text = "CustomerTransaction";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnAccountStat;
    }
}