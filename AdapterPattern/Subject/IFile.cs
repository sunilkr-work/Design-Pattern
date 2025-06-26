using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Subject
{
    internal interface IFile
    {
        string ConvertToJson(string s);
    }
}
