using System;
using System.Threading.Tasks;
using LemonwayWebservice;
using LemonwayWebservice.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonwayWebserviceTest
{
    [TestClass]
    public class ConvertServiceTest
    {
        private ConvertService fibonacciService = new ConvertService();
        [TestMethod]
        public void TestSemplXml()
        {
            
            Assert.IsTrue(fibonacciService.XmlToJson("<foo>bar</foo>") == "{\"foo\":\"bar\"}");
        }
        [TestMethod]
        public void TestBadXml()
        {
            Assert.IsTrue(fibonacciService.XmlToJson("<foo>hello</bar>") == "Bad Xml format");
        }
        [TestMethod]
        public void TestComplexXml()
        {
            string xml = "<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>";
            string json = "{\"TRANS\":{\"HPAY\":{\"ID\":\"103\",\"STATUS\":\"3\",\"EXTRA\":{\"IS3DS\":\"0\",\"AUTH\":\"031183\"},\"INT_MSG\":null,\"MLABEL\":\"501767XXXXXX6700\",\"MTOKEN\":\"project01\"}}}";
            Assert.IsTrue(fibonacciService.XmlToJson(xml) == json);
        }


    }
}
