using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Bank___Student_Bank.Modules
{
    public class MenuStripTool
    {
       // public MenuStripTool() { }
        public static void openCustReg()
        {
            //this.Close();
            CustomerRegistration cus = new CustomerRegistration();
            cus.ShowDialog();
        }
        public static void openiBSBReg()
        {
            //need to create a form for this one 
            iBSBRegistration iBSBRegistration = new iBSBRegistration();
            iBSBRegistration.ShowDialog();
        }
        public static void openCusLogin()
        {
            CustomerLogin cusLogin = new CustomerLogin();
            cusLogin.ShowDialog();
        }
        public static void openiBSBLogin()
        {
            DummyLogin dummyLogin = new DummyLogin();
            dummyLogin.ShowDialog();
        }
        public static void openAbout()
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
