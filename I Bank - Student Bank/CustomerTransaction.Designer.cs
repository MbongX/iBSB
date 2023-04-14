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
            gbDeposit = new GroupBox();
            gbWithdraw = new GroupBox();
            gbAccountStat = new GroupBox();
            lbStat = new ListBox();
            lblWithdrawAmount = new Label();
            lblDepositAmount = new Label();
            txtDeposit = new TextBox();
            txtWithdraw = new TextBox();
            btnDepo = new Button();
            btnWithd = new Button();
            label1 = new Label();
            gbDeposit.SuspendLayout();
            gbWithdraw.SuspendLayout();
            gbAccountStat.SuspendLayout();
            SuspendLayout();
            // 
            // btnDeposit
            // 
            btnDeposit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeposit.Location = new Point(28, 80);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(256, 55);
            btnDeposit.TabIndex = 0;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = true;
            btnDeposit.Click += btnDeposit_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnWithdraw.Location = new Point(830, 80);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(256, 55);
            btnWithdraw.TabIndex = 1;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnAccountStat
            // 
            btnAccountStat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccountStat.Location = new Point(424, 80);
            btnAccountStat.Name = "btnAccountStat";
            btnAccountStat.Size = new Size(256, 55);
            btnAccountStat.TabIndex = 2;
            btnAccountStat.Text = "Account Statement";
            btnAccountStat.UseVisualStyleBackColor = true;
            btnAccountStat.Click += btnAccountStat_Click;
            // 
            // gbDeposit
            // 
            gbDeposit.Controls.Add(btnDepo);
            gbDeposit.Controls.Add(txtDeposit);
            gbDeposit.Controls.Add(lblDepositAmount);
            gbDeposit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbDeposit.Location = new Point(20, 148);
            gbDeposit.Name = "gbDeposit";
            gbDeposit.Size = new Size(297, 87);
            gbDeposit.TabIndex = 3;
            gbDeposit.TabStop = false;
            gbDeposit.Text = "Deposit";
            // 
            // gbWithdraw
            // 
            gbWithdraw.Controls.Add(btnWithd);
            gbWithdraw.Controls.Add(txtWithdraw);
            gbWithdraw.Controls.Add(lblWithdrawAmount);
            gbWithdraw.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbWithdraw.Location = new Point(819, 148);
            gbWithdraw.Name = "gbWithdraw";
            gbWithdraw.Size = new Size(297, 87);
            gbWithdraw.TabIndex = 4;
            gbWithdraw.TabStop = false;
            gbWithdraw.Text = "Withdraw";
            // 
            // gbAccountStat
            // 
            gbAccountStat.Controls.Add(lbStat);
            gbAccountStat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbAccountStat.Location = new Point(20, 241);
            gbAccountStat.Name = "gbAccountStat";
            gbAccountStat.Size = new Size(1099, 260);
            gbAccountStat.TabIndex = 4;
            gbAccountStat.TabStop = false;
            gbAccountStat.Text = "Statement";
            // 
            // lbStat
            // 
            lbStat.FormattingEnabled = true;
            lbStat.ItemHeight = 15;
            lbStat.Location = new Point(14, 26);
            lbStat.Name = "lbStat";
            lbStat.Size = new Size(1079, 214);
            lbStat.TabIndex = 0;
            // 
            // lblWithdrawAmount
            // 
            lblWithdrawAmount.AutoSize = true;
            lblWithdrawAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblWithdrawAmount.Location = new Point(12, 26);
            lblWithdrawAmount.Name = "lblWithdrawAmount";
            lblWithdrawAmount.Size = new Size(52, 15);
            lblWithdrawAmount.TabIndex = 0;
            lblWithdrawAmount.Text = "Amount";
            // 
            // lblDepositAmount
            // 
            lblDepositAmount.AutoSize = true;
            lblDepositAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDepositAmount.Location = new Point(9, 26);
            lblDepositAmount.Name = "lblDepositAmount";
            lblDepositAmount.Size = new Size(52, 15);
            lblDepositAmount.TabIndex = 1;
            lblDepositAmount.Text = "Amount";
            // 
            // txtDeposit
            // 
            txtDeposit.Location = new Point(9, 44);
            txtDeposit.Name = "txtDeposit";
            txtDeposit.Size = new Size(151, 23);
            txtDeposit.TabIndex = 2;
            // 
            // txtWithdraw
            // 
            txtWithdraw.Location = new Point(12, 44);
            txtWithdraw.Name = "txtWithdraw";
            txtWithdraw.Size = new Size(151, 23);
            txtWithdraw.TabIndex = 3;
            // 
            // btnDepo
            // 
            btnDepo.Location = new Point(184, 35);
            btnDepo.Name = "btnDepo";
            btnDepo.Size = new Size(107, 38);
            btnDepo.TabIndex = 3;
            btnDepo.Text = "Deposit";
            btnDepo.UseVisualStyleBackColor = true;
            // 
            // btnWithd
            // 
            btnWithd.Location = new Point(184, 35);
            btnWithd.Name = "btnWithd";
            btnWithd.Size = new Size(107, 38);
            btnWithd.TabIndex = 4;
            btnWithd.Text = "Withdraw";
            btnWithd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(469, 25);
            label1.Name = "label1";
            label1.Size = new Size(157, 32);
            label1.TabIndex = 4;
            label1.Text = "Transactions";
            // 
            // CustomerTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 513);
            Controls.Add(label1);
            Controls.Add(gbAccountStat);
            Controls.Add(gbWithdraw);
            Controls.Add(gbDeposit);
            Controls.Add(btnAccountStat);
            Controls.Add(btnWithdraw);
            Controls.Add(btnDeposit);
            Name = "CustomerTransaction";
            Text = "CustomerTransaction";
            gbDeposit.ResumeLayout(false);
            gbDeposit.PerformLayout();
            gbWithdraw.ResumeLayout(false);
            gbWithdraw.PerformLayout();
            gbAccountStat.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnAccountStat;
        private GroupBox gbDeposit;
        private Button btnDepo;
        private TextBox txtDeposit;
        private Label lblDepositAmount;
        private GroupBox gbWithdraw;
        private Button btnWithd;
        private TextBox txtWithdraw;
        private Label lblWithdrawAmount;
        private GroupBox gbAccountStat;
        private ListBox lbStat;
        private Label label1;
    }
}