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
using I_Bank___Student_Bank.Service;

namespace I_Bank___Student_Bank
{
    public partial class CustomerTransaction : Form
    {
        public CustomerTransaction()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e) => showDeposit();


        private void btnWithdraw_Click(object sender, EventArgs e) => showWithdraw();


        private void btnAccountStat_Click(object sender, EventArgs e)
        {
            showAccountStat();
            //pull out account data for client
        }

        private void CustomerTransaction_Load(object sender, EventArgs e)
        {
            //hiding the Deposit,withdraw and statement groupbox along with its elements
            gbAccountStat.Visible = false;
            gbDeposit.Visible = false;
            gbWithdraw.Visible = false;
        }

        private void btnDepo_Click(object sender, EventArgs e)
        {
            string amount = txtWithdraw.Text;

            if (Validation.notNull(amount))
            {
                if (Validation.IsNumber(amount))
                {
                    //perform withdraw but first check if the account balance is all good to perform such an amount
                    double withdrawAmount = Convert.ToDouble(amount);
                }
                else
                {
                    MessageBox.Show("Withdraw Amount must only contains numbers", "Invalid Withdraw Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtWithdraw.Select();
                    txtWithdraw.Focus();
                }
            }
            else
            {
                MessageBox.Show("Withdraw Amount cannot be blank", "No withrawl amount supplied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWithd_Click(object sender, EventArgs e)
        {
            //validating entry by user
            string amount = txtDeposit.Text;
            if (Validation.notNull(amount))
            {
                if (Validation.IsNumber(amount))
                {//Perfom Deposit
                    double depositAmount = Convert.ToDouble(amount);
                }
                else
                {
                    MessageBox.Show("Deposit Amount must only contains numbers", "Invalid Deposit Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDeposit.Select();
                    txtDeposit.Focus();
                }
            }
            else
            {
                MessageBox.Show("Only numbers are allowed and/or fields cannot be blank", "Invalid Amount Entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDeposit.Select();
                txtDeposit.Focus();
            }
        }
        private void logOutTransactionMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //custom methods
        //unhiding elemets
        private void showDeposit()
        {
            gbWithdraw.Visible= false;
            gbDeposit.Visible = true;
        }
        private void showWithdraw()
        {
            gbDeposit.Visible = false;
            gbWithdraw.Visible = true;
        }
        private void showAccountStat()
        {
            gbAccountStat.Visible = true;
        }

        private void aboutUsTransactionMenu_Click(object sender, EventArgs e) => MenuStripTool.openAbout();
    }
}
