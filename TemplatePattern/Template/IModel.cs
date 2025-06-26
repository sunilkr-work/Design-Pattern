using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern.Template
{
    internal interface IModel
    {
        string Name { get; }
        void LoadModel();
        void PreProcess();
        void TrainModel();

        void EvaluateModel();
        void SaveModel();
        void OrderedExecution();
    }
}
