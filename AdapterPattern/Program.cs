using AdapterPattern.Adaptee;
using AdapterPattern.Adapter;
using AdapterPattern.Subject;
using System;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var xmlProvider = new XMLProvider();
            var file = new File();
            var jsonAdapter = new JSONAdapter(xmlProvider);
            string jsonResult = jsonAdapter.ConvertToJson("id:1");
            Console.WriteLine(jsonResult);

        }
    }
}
