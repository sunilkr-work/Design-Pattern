using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.OtherClasses
{
    internal class Start: IStart
    {
        public void start()
        {
            Console.WriteLine("start called from Start class");
        }
    }
}
