using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class File:IFileSystem
    {
        public string name { get; private set; }

        public File(string name)
        {
            this.name = name;
        }

        public void ExpandAll(int indent)
        {
            Console.WriteLine(new string(' ', indent) + name);
        }
    }
}
