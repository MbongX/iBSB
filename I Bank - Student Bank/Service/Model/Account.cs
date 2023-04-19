using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Bank___Student_Bank.Service.Model
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public AccountType AccType { get; set; }
        public double InitialDeposit { get; set; }
        public double CurrentBalance { get; set; }
        public DateTime DateCreated { get; set; }

        public Account() { }
        public Account(int id, string firstname, string lastname, AccountType accountType, double initDeposit, double balance) {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.AccType = accountType;
            this.InitialDeposit = initDeposit;
            this.CurrentBalance = balance;
            this.DateCreated = DateTime.Now;
        }
        
        public static int AccGen(string type)
        {
            int min = 0, max = 0;
            //check account type
            if (type == "Current")
            {
                //current : 121*********
                min = 1210000000;
                max = 1219999999;
                return NumGen(min, max);
            }
            if (type == "Savings")
            {
                ////savings : 1041**********
                min = 1041000000;
                max = 1041999999;
                return NumGen(min, max);
            }
            if (type == "Fixed Deposit")
            
                //Fixed Deposit : 6063 **** ****
                min = 2041000000;
                max = 2041999999;
                return NumGen(min, max);
            
        }
        private static int NumGen(int min, int max)
        { 
            Random rand  =  new Random();
            return rand.Next(min, max);
        }
    }
}
