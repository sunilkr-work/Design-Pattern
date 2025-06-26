using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class User
    {
      public List<IOnlineTransaction> transactions = new List<IOnlineTransaction>();
      
        public User(List<IOnlineTransaction> transactions) {
            this.transactions = transactions;
        
        }
        public void  Execute()
        {
            foreach (var transaction in transactions)
            {
                Console.WriteLine($"{transaction.GetType()}, Amount:{transaction.Deposit(100)}");

            }
        }


    }
}
