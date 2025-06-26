using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandPattern.receiver
{
    internal class Light
    {
        public void ON()
        {
            Console.WriteLine("Light is ON");
        }

        public void OFF()
        {
            Console.WriteLine("Light is OFF");
        }
    }
}
