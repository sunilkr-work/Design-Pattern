using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.HistoryConstraint
{
    internal abstract  class WithdrawableAccount:NonWithdrawableAccount
    {
        public abstract double Withdraw(double amount);
    }
}
