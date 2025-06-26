using FacadePattern.OtherClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.FacadeService
{
    internal class Facade :IFacade
    {
        public IBoot boot{get;set;}
        public IStart start { get;set;}

        public Facade()
        {
            this.boot = new Boot();
            this.start =new Start();
        }
        
        public void StartSystem()
        {
            boot.startBooting();
            start.start();
        }
    }
}
