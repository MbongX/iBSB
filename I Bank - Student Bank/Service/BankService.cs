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

        DateTime today = new DateTime().Date;

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

        public List<Account> GetNewAccounts() {
            List<Account> new_acc = new List<Account>();
            this.accounts.ForEach(account => {
                Account acc = account;
                if(acc.DateCreated.Date.Equals(this.today)){
                    new_acc.Add(acc);
                }
            });
            return new_acc;
        }

        public List<Account> GetNewAccountsMonth() {
            List<Account> new_month = new List<Account>();
            this.accounts.ForEach(acc=>{
                Account account = acc;
                if (account.DateCreated.Month.Equals(this.today.Month)) {
                    new_month.Add(account);
                }
            });
            return new_month;
        }

        // Will return new Account Balance after Deposit or withdrawal
        public double Transact(int AccountId, double amount,bool isDeposit=true) {
            // Is Account set
            bool isAccountSet = false;
            //Find account
            foreach (Account account in this.accounts) {
                if (account.Id.Equals(AccountId)) {
                    Transaction transaction = new Transaction();
                    double finalAmount = isDeposit?account.CurrentBalance + amount:account.CurrentBalance - amount;
                    transaction.ClosingAmount = finalAmount;
                    transaction.OpeningAmount = account.CurrentBalance;
                    transaction.date = new DateTime().Date;
                    transaction.AccId = AccountId;
                    transaction.TransactionTypeId = isDeposit?1:2;
                    transaction.Amount = amount;
                    account.CurrentBalance = finalAmount;
                    // Add transactio to list
                    this.transactions.Add(transaction);
                    return finalAmount;
                }

            }
            return 0.0;

        }

        public List<Transaction> getAccountTransactions(int AccountId) {
            return (List<Transaction>)this.transactions.Where(t => t.AccId.Equals(AccountId));
        }

        void CreateAccount(String firstname,String lastname,int acc_type,double initialDeposit) {
            AccountType account_type = (AccountType)this.accountTypes.Where(o => o.Id.Equals(acc_type));
            this.accounts.Add(new Account( this.accounts.Count()+1 , firstname,lastname, account_type,initialDeposit,initialDeposit));
        }

    }
}
