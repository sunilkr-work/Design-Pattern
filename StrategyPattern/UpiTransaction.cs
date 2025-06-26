using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class UpiTransaction :IOnlineTransaction
    {
        private double Balance = 0;
        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }

        public double Withdraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }
    }
}
