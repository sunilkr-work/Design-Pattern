using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.humanDisease
{
    internal class HumanDisease:IHumandisease
    {
        public string GeneralSymtom()
        {
            return "headache";
        }
    }
}
