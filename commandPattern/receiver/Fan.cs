using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandPattern.receiver
{
    internal class Fan
    {
        public void ON()
        {
            Console.WriteLine("Fan is ON");
        }
        public void OFF()
        {
            Console.WriteLine("Fan is OFF");
        }
    }
}
