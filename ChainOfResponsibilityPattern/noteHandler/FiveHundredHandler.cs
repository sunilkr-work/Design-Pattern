using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.noteHandler
{
    internal class FiveHundredHandler : NoteHandler
    {
        int totalFiveHundredNotes {  get; set; }
        public FiveHundredHandler(int totalFiveHundredNotes)
        {
            this.totalFiveHundredNotes = totalFiveHundredNotes;
        }
        public override void ValidateAndWithdraw(int amount)
        {
            if (amount > 500)
            {
                int dispenseNumber = amount / 500;
                if (dispenseNumber > totalFiveHundredNotes)
                {

                    Console.WriteLine($"dispensing 500*{dispenseNumber}");
                    amount = amount - (totalFiveHundredNotes * 500);
                    totalFiveHundredNotes = 0;
                    Console.WriteLine($"Unable to dispense remaining amount to dispense {amount}");
                }
                else
                {
                    totalFiveHundredNotes -= dispenseNumber;
                    Console.WriteLine($"dispensing 500*{dispenseNumber}");
                    amount = amount - (dispenseNumber * 500);
                    Console.WriteLine($"Unable to dispense remaining amount to dispense {amount}");

                }
            }
        }
    }
}
