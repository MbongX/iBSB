using I_Bank___Student_Bank.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace I_Bank___Student_Bank.Service
{
    public class BankService
    {

        List<AccountType> accountTypes = new List<AccountType>();
        List<TransactionType>transactionTypes = new List<TransactionType>();
        List<Account> accounts = new List<Account>();
        List<Transaction> transactions = new List<Transaction>();

        public BankService() {
            this.InitAccountTypes();
            this.InitTransactionTypes();
        }

        void InitAccountTypes() { 
            accountTypes.Add(new AccountType(1,"Current"));
            accountTypes.Add(new AccountType(2,"Saving"));
            accountTypes.Add(new AccountType(3,"Fixed Deposit"));
        }

        void InitTransactionTypes() {
            transactionTypes.Add(new TransactionType(1, "Deposit"));
            transactionTypes.Add(new TransactionType(2, "Withdrawal"));
        }

        List<AccountType> GetAccountTypes() => this.accountTypes;
        List<TransactionType> GetTransactionTypes() => this.transactionTypes;

        public static void AccNumberGen(string Name)
        { 
            //generate account Number
        }


    }
}
