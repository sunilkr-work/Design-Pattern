using SimpleFactory.Verity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class PizzaFactory
    {
        public IDominosPizza CreatePizza(string type)
        {
            if(type == "classic") return new ClassicPizza();
            else if(type =="standard") return new StandardPizza();
            return null;
        }
    }
}
