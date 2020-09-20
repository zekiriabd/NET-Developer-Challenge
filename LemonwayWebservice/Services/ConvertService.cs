using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Schema;

namespace LemonwayWebservice.Services
{
    public class ConvertService : IConvertService
    {
        private static readonly ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private const string BADXML= "Bad Xml format";


        public string XmlToJson(string xml)
        {
            string result = "";
            
            void RemoveAttributes(XmlDocument xmlDoc)
            {
                var root = xmlDoc.FirstChild;
                if (root.Attributes != null)
                {
                    root.Attributes.RemoveAll();
                }
                foreach (XmlNode child in root.ChildNodes)
                {
                    if (child.Attributes != null)
                    {
                        child.Attributes.RemoveAll();
                    }
                }
            }

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(xml);
                Log.Debug("Original Xml : "  + xml);

                RemoveAttributes(doc);
                result = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.None);
                
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                result = BADXML;
            }
            return result;
        }
    }
}