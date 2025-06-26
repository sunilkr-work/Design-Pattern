using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.HistoryConstraint
{
    internal abstract class NonWithdrawableAccount
    {
        internal double Amount = 0;
        public abstract void Deposit(double amount);
       
       
    }
}
