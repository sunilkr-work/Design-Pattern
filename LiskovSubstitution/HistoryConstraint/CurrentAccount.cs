using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution.HistoryConstraint
{
    internal class CurrentAccount:WithdrawableAccount
    {
        public override void Deposit(double amount)
        {
            Amount += amount;
        }

        public override double Withdraw(double amount)
        {

            //if(Amount - amount >= 0)
            //{

            //}
            double tm = Amount - amount;
            bool bl =tm>=0;

            switch (bl)
            {
                //bool a = tm > 0;
                case  true:
                    Amount -= amount;
                    break;
                default:
                    throw new Exception("You have less money than requested, please try some less value");
            }


            return tm;
        }
    }
}
