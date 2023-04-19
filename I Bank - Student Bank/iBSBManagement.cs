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
    public partial class iBSBManagement : Form
    {
        DateTime now = DateTime.Now;
        int var1, var2;
        public iBSBManagement()
        {
            InitializeComponent();
        }

        private void iBSBManagement_Load(object sender, EventArgs e)
        {
            //heading
            lblReportHeading.Text = " | Report | " + now;

            //Listview/listbox which displays the summary


            //Footer, which consolidates the total number or accounts created today plus the total amount deposited by out customers
            lblReportingFooter.Text = "Today we opened {0} account(s) with a total of R {1}";
        }

        private void exitReportMenu_Click(object sender, EventArgs e) => MenuStripTool.Exit();

        private void aboutUsReportMenu_Click(object sender, EventArgs e) => MenuStripTool.openAbout();
    }
}
