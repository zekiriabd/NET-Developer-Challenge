using LemonwayWebservice.Services;
using log4net;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Xml;
using System.Xml.Schema;

namespace LemonwayWebservice
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class ConvertController : System.Web.Services.WebService
    {
        private static readonly ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private ConvertService convertService = new ConvertService();

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string XmlToJson(XmlObject xml)
        {
            Log.Info("Call FibonacciAsync");
            try
            {
                var result = convertService.XmlToJson(xml.xmlData);
                Log.Info(" Result : " + result);
                return result;
                
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return null;
            }
        }
    }
}
