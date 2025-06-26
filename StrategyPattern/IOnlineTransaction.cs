using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal interface IOnlineTransaction
    {
       double Withdraw(double amount);
       double Deposit(double amount);
    }
}
