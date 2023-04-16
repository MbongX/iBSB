using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_Bank___Student_Bank
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e) => openCustReg();
        private void btniBSBEmp_Click(object sender, EventArgs e) => openiBSBLogin();
        private void Main_Load(object sender, EventArgs e)
        {

        }
        //Menu ToolStrip Events
            // Opens the customer registration form
        private void mtsRegCustomer_Click(object sender, EventArgs e) =>btnCustomer_Click(sender, e);
            // Opens the emp reg form
        private void mtsRegiBSBEmp_Click(object sender, EventArgs e) => openiBSBReg();
            // Opens the Vustomer login form
        private void mtsLoginCustomer_Click(object sender, EventArgs e) => openCusLogin();
            // Opens the Employer Login form
        private void mtsLoginiBSBEmp_Click(object sender, EventArgs e) => btniBSBEmp_Click(sender, e);
            // calls the Exit function to terminate the client/winForm
        private void mtsExit_Click(object sender, EventArgs e) => Exit();
   
        private void Exit()
        {
            Application.Exit();
        }


        //opening new forms via methods
        private void openCustReg()
        {
            //this.Close();
            CustomerRegistration cus = new CustomerRegistration();
            cus.ShowDialog();
        }
        private void openiBSBReg()
        { 
            //need to create a form for this one 
            iBSBRegistration iBSBRegistration = new iBSBRegistration();
            iBSBRegistration.ShowDialog();
        }
        private void openCusLogin()
        { 
            CustomerLogin cusLogin = new CustomerLogin();
            cusLogin.ShowDialog();
        }
        private void openiBSBLogin()
        {
            DummyLogin dummyLogin = new DummyLogin();
            dummyLogin.ShowDialog();
        }
    }
}
