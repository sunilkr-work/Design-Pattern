using System;

namespace TemplatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var trainModel = new TrainModel("skModel", ModelType.NEURAL);
            trainModel.RunModel();

        }
    }
}
