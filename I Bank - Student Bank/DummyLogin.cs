using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using I_Bank___Student_Bank.Modules;

namespace I_Bank___Student_Bank
{
    public partial class DummyLogin : Form
    {
        
        public DummyLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (Validation.validateLogin(username, password))
            {
                if (username != "Admin" || password != "Admin123")
                {
                    MessageBox.Show("Invalid Login Credentials", "Invalid login credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    iBSBManagement ibsb = new iBSBManagement();
                    MessageBox.Show("You have been logged in as Admin", "Successful Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Exit();
                    ibsb.Show();
                }
            }
            else
            {
                MessageBox.Show("Validation of inserted data failed due to incorrect data types and/or null field", "Data Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //custom function
        void Exit()
        { 
            this.Close();
        }

    }
}
