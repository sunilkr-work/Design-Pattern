using commandPattern.receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandPattern.command
{
    internal class LightCommand : IComman
    {
        private Light _light;
        public LightCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            Console.WriteLine("Executing Light Command. Light is on");
        }

        public void Undo()
        {
            Console.WriteLine("Undoing Light Command. Light is off");
        }
    }
}
