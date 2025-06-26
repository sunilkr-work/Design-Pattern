using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Verity
{
    internal class ClassicWheatGarlicBread : IGarlicBread
    {
        public void PrepareGarlicBread()
        {
            Console.WriteLine("ClassicWheatGarlicBread");
        }
    }
}
