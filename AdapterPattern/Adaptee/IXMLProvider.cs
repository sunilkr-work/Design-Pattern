using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adaptee
{
    internal interface IXMLProvider
    {
        string GetDataInXML(string s);
    }
}
