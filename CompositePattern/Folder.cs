using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    internal class Folder: IFileSystem
    {
        public string name { get; private set; }
        private List<IFileSystem> fileSystems;

        public Folder(string name)
        {
            this.name = name;
            fileSystems = new List<IFileSystem>();
        }

        public void Add(IFileSystem fileSystem)
        {
            fileSystems.Add(fileSystem);
        }

        public void ExpandAll(int indent)
        {
            foreach(IFileSystem fileSystem in fileSystems)
            {
                Console.WriteLine(new string(' ', indent)+fileSystem.name);
                if(fileSystem is Folder folder)
                {
                    folder.ExpandAll(indent + 2);
                }
            }
        }
   
    }
}
