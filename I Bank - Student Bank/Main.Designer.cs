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
            SuspendLayout();
            // 
            // btnCustomer
            // 
            btnCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomer.Location = new Point(74, 163);
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
            btniBSBEmp.Location = new Point(462, 163);
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
            label1.Location = new Point(97, 62);
            label1.Name = "label1";
            label1.Size = new Size(581, 25);
            label1.TabIndex = 2;
            label1.Text = "Please select whether you are a \"Customer\" or an \"iBSB Employee\"";
            label1.Click += label1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btniBSBEmp);
            Controls.Add(btnCustomer);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCustomer;
        private Button btniBSBEmp;
        private Label label1;
    }
}