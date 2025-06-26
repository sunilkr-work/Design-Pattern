using AdapterPattern.Adaptee;
using AdapterPattern.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adapter
{
    internal interface IJSONAdapter : IFile
    {
        IXMLProvider XMLProvider { get; }

    }
}
