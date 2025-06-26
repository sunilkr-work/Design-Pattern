using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern.Template
{
    internal class ConcreteModel: IModel
    {
        public string Name { get; set; }
        public void  LoadModel()
        {
            Console.WriteLine("load from ConcreteModel");
        }
        public void PreProcess()
        {
            Console.WriteLine("PreProcess from ConcreteModel");
        }
       virtual public void TrainModel()
        {
            Console.WriteLine("TrainModel from ConcreteModel");
        }
        public void EvaluateModel()
        {
            Console.WriteLine("EvaluateModel from ConcreteModel");
        }
        public void SaveModel()
        {
            Console.WriteLine("SaveModel from ConcreteModel");
        }
        public void OrderedExecution()
        {
            Console.WriteLine("OrderedExecution from ConcreteModel");
            LoadModel();
            PreProcess();
            TrainModel();
            EvaluateModel();
            SaveModel();
        }

    }
}
