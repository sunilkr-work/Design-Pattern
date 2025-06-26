using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal interface IFileSystem
    {
        string name { get; }
        void ExpandAll(int indent);

    }
}
