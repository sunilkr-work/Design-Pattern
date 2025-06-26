using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.HistoryConstraint
{
    internal class Client
    {
        public List<NonWithdrawableAccount> _nonWithdrawableAccount;
        public List<WithdrawableAccount> _withdrawableAccount;
        public Client(List<NonWithdrawableAccount> nonWithdrawableAccount, List<WithdrawableAccount> withdrawableAccount)
        {
            _nonWithdrawableAccount = nonWithdrawableAccount;
            _withdrawableAccount = withdrawableAccount;
        }

        public void processTransaction()
        {
            foreach (var account in _nonWithdrawableAccount)
            {
                account.Deposit(1000);
                Console.WriteLine($"{account.GetType()} Amount: {account.Amount}");
            }

            foreach (var account in _withdrawableAccount)
            {
                account.Deposit(1000);
                account.Withdraw(1000);
                Console.WriteLine($"{account.GetType()} Amount: {account.Amount}");
            }
        }
    }
}
