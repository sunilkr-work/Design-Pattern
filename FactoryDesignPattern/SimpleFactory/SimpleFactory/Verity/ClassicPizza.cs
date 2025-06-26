using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Verity
{
    internal class ClassicPizza:IDominosPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Made classic pizza with");
        }
    }
}
