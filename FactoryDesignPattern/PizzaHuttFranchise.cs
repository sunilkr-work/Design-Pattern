using FactoryDesignPattern.Verity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class PizzaHuttFranchise : IFastFoodFactory
    {
        public IPizza CreatePizza(string type)
        {
            if (type == "standard") return new StandardWheatPizza();
            return null;
        }

        public IGarlicBread CreateGarlicBread(string type)
        {
            if (type == "standard") return new StandardWheatGarlicBread();
            return null;
        }
    }
}
