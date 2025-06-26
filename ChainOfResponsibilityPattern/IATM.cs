using ChainOfResponsibilityPattern.noteHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    internal interface IATM
    {
        string ATMName { get; set; }
        int Amount { get; set; }

       public   NoteHandler noteHandler { get; set; }

        public void Withdraw(int amount);
       
    }
}
