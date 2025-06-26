using FacadePattern.FacadeService;
using FacadePattern.OtherClasses;
using System;

namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Facade facadeService = new Facade();
            facadeService.StartSystem();


        }
    }
}
