using commandPattern.receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandPattern.command
{
    internal class FanCommand : IComman
    {
        private Fan _fan;

        public FanCommand(Fan fan)
        {
            _fan = fan;
        }

        public void Execute()
        {
            Console.WriteLine("Executing Fan Command. Fan is on");
            _fan.ON();
        }

        public void Undo()
        {
            Console.WriteLine("Undoing Fan Command. Fan is off");
            _fan.OFF();
        }
    }
}
