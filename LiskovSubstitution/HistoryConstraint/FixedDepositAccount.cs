using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.HistoryConstraint
{
    internal class FixedDepositAccount:NonWithdrawableAccount
    {
        public override void Deposit(double amount)
        {
            Amount += amount;
        }
    }
}
