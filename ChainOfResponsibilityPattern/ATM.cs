using ChainOfResponsibilityPattern.noteHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    internal class ATM : IATM
    {
        public string ATMName { get; set; }
        public int Amount { get; set; }
        public NoteHandler noteHandler { get; set; }

        public ATM(NoteHandler noteHandler)
        {
            this.noteHandler = noteHandler;
        }

        public void Withdraw(int amount)
        {
            SetHandler();
            noteHandler.next.ValidateAndWithdraw(amount);
        }

        void SetHandler()
        {

            //var a = new ThousandHandler(10);
            ////a = a.next;
            //a.next = new FiveHundredHandler(10);
            var a = noteHandler;
            noteHandler.next = new ThousandHandler(10);
            noteHandler = noteHandler.next;
            noteHandler.next = new FiveHundredHandler(10);
            noteHandler = a;





        }

       
    }
}
