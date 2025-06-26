using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern.Template
{
    internal class DecisionTreeModel:ConcreteModel
    {
        public override  void TrainModel()
        {
            Console.WriteLine(" Decision Tree overidded concrete train model");
        }
    }
}
