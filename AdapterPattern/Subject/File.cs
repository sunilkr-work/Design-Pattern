using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Subject
{
    internal class File : IFile
    {
        public string ConvertToJson(string s)
        {
            return "aa";
        }
    }
}
