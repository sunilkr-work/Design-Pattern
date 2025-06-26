using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern.Template
{
    internal class NeuralNetworkModel:ConcreteModel
    {
        public override void TrainModel()
        {
            Console.WriteLine(" NeuralNetworkModel Tree overidded concrete train model");
        }
    }
}
