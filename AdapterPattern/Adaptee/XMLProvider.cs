using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adaptee
{
    internal class XMLProvider: IXMLProvider
    {
        public string GetDataInXML(string s)
        {
            return s;
        }
    }
}
