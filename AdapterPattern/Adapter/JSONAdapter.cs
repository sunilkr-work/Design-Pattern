using AdapterPattern.Adaptee;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.Adapter
{
    internal class JSONAdapter : IJSONAdapter
    {
        public  IXMLProvider XMLProvider { get; set; }
        public JSONAdapter(IXMLProvider xMLProvider)
        {
            XMLProvider = xMLProvider;
        }
        public string ConvertToJson(string s)
        {
            string xml =  XMLProvider.GetDataInXML(s);

            var separate = xml.Split(':');

            return $@"{{
                {separate[0]} : {separate[1]}
}}";
        }
    }
}
