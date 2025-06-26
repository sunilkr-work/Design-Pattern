using FactoryDesignPattern.Verity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class DominosPizzaFranchise: IFastFoodFactory
    {
        public IPizza CreatePizza(string type)
        {
            if (type == "standard") return new StandardPizza();
            return null;
        }

        public IGarlicBread CreateGarlicBread(string type)
        {
            if (type == "standard") return new StandardGarlicBread();
            return null;
        }
    }
}
