using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class PhonePe : IOnlineTransaction
    {
        private double  Balance =0;
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

        //double IOnlineTransaction.Deposit(double amount)
        //{
        //    throw new NotImplementedException();
        //}

        //double IOnlineTransaction.Withdraw(double amount)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
