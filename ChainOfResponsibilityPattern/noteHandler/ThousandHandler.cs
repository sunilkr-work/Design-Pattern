using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.noteHandler
{
    internal class ThousandHandler:NoteHandler
    {
        int totalThousandNotes { get; set; }
        public ThousandHandler(int totalThousandNotes)
        {
            this.totalThousandNotes = totalThousandNotes;
        }
        public override void ValidateAndWithdraw(int amount)
        {
            if (amount > 1000 && totalThousandNotes>0)
            {
                int dispenseNumber = amount / 1000;
                if (dispenseNumber > totalThousandNotes)
                {

                    Console.WriteLine($"dispensing 1000*{dispenseNumber}");
                    amount = amount - (totalThousandNotes * 1000);
                    totalThousandNotes = 0;
                    next.ValidateAndWithdraw(amount);
                }
                else
                {
                    totalThousandNotes -= dispenseNumber;
                    Console.WriteLine($"dispensing 1000*{dispenseNumber}");
                    amount = amount - (dispenseNumber * 1000);
                    next.ValidateAndWithdraw(amount);


                }
            }
        }
    }
}
