using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.OtherClasses
{
    internal class Boot: IBoot
    {
        public void startBooting()
        {
            Console.WriteLine("starting booting from Boot");
        }
    }
}
