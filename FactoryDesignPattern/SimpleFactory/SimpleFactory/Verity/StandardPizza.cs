using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Verity
{
    internal class StandardPizza:IDominosPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Made standard pizza with");
        }
    }

}
