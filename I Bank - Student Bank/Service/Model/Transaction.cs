using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Bank___Student_Bank.Service.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public int AccId { get; set; }
        public int TransactionTypeId { get; set; }
        public double Amount { get; set; }
        public double OpeningAmount { get; set; }
        public double ClosingAmount { get; set; }
        public DateTime date { get; set; }

        public Transaction() { }
        public Transaction(int id, int accId, int transactionTypeId, double amt, double opening, double closing, DateTime date)
        {
            this.Id = id;
            this.AccId = accId;
            this.TransactionTypeId = transactionTypeId;
            this.Amount = amt;
            this.OpeningAmount = opening;
            this.ClosingAmount = closing;
            this.date = date;
        }
    }
}
