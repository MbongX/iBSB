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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //would have used a try block if db was included
            //validation user entry
            string accnumber = txtUsername.Text, pin=txtPassword.Text;
            if (Validation.notNull(accnumber) && Validation.notNull(pin))
            {
                if (Validation.IsNumber(accnumber) && Validation.IsNumber(pin))
                {
                    //perform login
                    int user = Convert.ToInt32(accnumber);
                    int pass = Convert.ToInt32(pin);    
                }
                else 
                {
                    MessageBox.Show("Only number are allowed on both fields", "Invalid Data Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Fields cannot be empty","Missing Field Data",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
