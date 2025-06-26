using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commandPattern.command
{
    internal interface IComman
    {
        void Execute();
        void Undo();
    }
}
