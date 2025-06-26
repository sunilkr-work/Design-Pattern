using System;
using System.Collections.Generic;
using System.Text;
using TemplatePattern.Template;

namespace TemplatePattern
{
    internal class TrainModel
    {
        ModelType type;
        string Name;
        IModel model;

        public TrainModel(string name, ModelType type)
        {
            Name = name;
            type = type;
        }

        public void  GetClass()
        {
            switch (type)
            { 
                case ModelType.NEURAL: 
                    model = new NeuralNetworkModel(); break;
                case ModelType.DecisionTree: 
                    model = new DecisionTreeModel(); break;
            
            }

        }

        public void RunModel()
        {
            GetClass();
            model.OrderedExecution();
        }
    }
}
