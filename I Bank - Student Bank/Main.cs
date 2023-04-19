using I_Bank___Student_Bank.Modules;

namespace I_Bank___Student_Bank
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //button event calls
        private void btnCustomer_Click(object sender, EventArgs e) => MenuStripTool.openCustReg();
        private void btniBSBEmp_Click(object sender, EventArgs e) => MenuStripTool.openiBSBLogin();
        private void btnCustLogin_Click(object sender, EventArgs e) => MenuStripTool.openCusLogin();
        private void btniBSBEmpReg_Click(object sender, EventArgs e) => MenuStripTool.openiBSBReg();
        private void Main_Load(object sender, EventArgs e)
        {

        }
        //Menu ToolStrip Events
        // Opens the customer registration form
        private void mtsRegCustomer_Click(object sender, EventArgs e) => btnCustomer_Click(sender, e);

        // Opens the Vustomer login form
        private void mtsLoginCustomer_Click(object sender, EventArgs e) => btnCustLogin_Click(sender, e);
        // Opens the Employer Login form
        private void mtsLoginiBSBEmp_Click(object sender, EventArgs e) => btniBSBEmp_Click(sender, e);

        // calls the Exit function to terminate the client/winForm
        private void mtsExit_Click(object sender, EventArgs e) => MenuStripTool.Exit();

        //Edit Menustrip


        //About Menustrip
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e) => MenuStripTool.openAbout();




    }
}
