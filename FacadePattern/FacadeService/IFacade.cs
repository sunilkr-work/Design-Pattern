using FacadePattern.OtherClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.FacadeService
{
    internal interface IFacade
    {
        public IBoot boot { get; set; }
        public IStart start { get; set; }
    }
}
