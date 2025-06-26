using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal interface IFastFoodFactory
    {
       public IPizza CreatePizza(string type);
       public IGarlicBread CreateGarlicBread(string type);
    }
}
