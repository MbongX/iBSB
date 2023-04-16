using System;
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
        public Account(int id, string firstname,string lastname, AccountType accountType,double initDeposit,double balance) {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.AccType = accountType;
            this.InitialDeposit = initDeposit;
            this.CurrentBalance = balance;
            this.DateCreated = DateTime.Now;
        }



    }
}
