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

        private void btnCustomer_Click(object sender, EventArgs e)
        {
   
       
            //CustomerRegistration cus = new CustomerRegistration();
            this.Visible = false;
            CustomerRegistration cus = new CustomerRegistration();
            cus.Show();
        }

        private void btniBSBEmp_Click(object sender, EventArgs e)
        {
            this.Hide();
            iBSBManagement ibsb = new iBSBManagement();
            ibsb.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
