using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Bank___Student_Bank.Service.Model
{
    public class Account
    {
        private int Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set;}
        private AccountType AccType { get; set; }
        private double InitialDeposit { get; set; }
        private double CurrentBalance { get; set; }

        public Account() { }
        public Account(int id, string firstname,string lastname, AccountType accountType,double initDeposit,double balance) {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.AccType = accountType;
            this.InitialDeposit = initDeposit;
            this.CurrentBalance = balance;
        }
    }
}
