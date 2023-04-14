namespace I_Bank___Student_Bank
{
    public partial class CustomerRegistration : Form
    {

        //global vars
        bool cbxSelected = false;
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {

            cbAccountType.Items.Add("Current");
            cbAccountType.Items.Add("Savings");
            cbAccountType.Items.Add("Fixed Deposit");

        }

        private void cbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccountType.SelectedIndex == 0)
            {
                rtbAccountDescription.Text =
                    "• Get easy access to your money for day-to-day expenses.\n" +
                    "• You get different types of cards depending on your income bracket."
                    ;
                cbxSelected = true;
            }
            if (cbAccountType.SelectedIndex == 1)
            {
                rtbAccountDescription.Text =
                     "• Keep your savings seperate from your everyday bank accountwith a savings account.\n" +
                     "• Earn interest on the amount you save every month."
                    ;
                cbxSelected = true;
            }
            if (cbAccountType.SelectedIndex == 2)
            {
                rtbAccountDescription.Text =
                    "• Savings account that you can only access when giving a certain amount of days' notice.\n" +
                    "• Earn more interest the longer you save."
                    ;
                cbxSelected = true;
            }

        }
        //Perform Registration
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string lName = txtFirstname.Text;
            string fName = txtLastname.Text;
            string iAmount = txtInitDeposit.Text;

            if (notNull(lName) && notNull(fName) && notNull(iAmount) && cbxSelected)
            {
                if (IsNumber(iAmount))
                {
                    //perform reg here

                }
                else
                {
                    MessageBox.Show("Initial deposit amount must contains only numbers", "Invalid Entry Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields should not be empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstname.Focus();
                txtLastname.Focus();
                cbAccountType.Focus();
            }
        }




        //Custom Functions
        bool IsNumber(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        bool notNull(string text)
        {
            bool validate;
            int charLength;
            text = text.Trim();
            charLength = text.Length;
            if (charLength == 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }
}