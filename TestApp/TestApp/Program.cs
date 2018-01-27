using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string xml = "<GetRewardsResponse><ResponseHeader><POSLoyaltyInterfaceVersion>1.0.0</POSLoyaltyInterfaceVersion><VendorName>KickbackPoints</VendorName><VendorModelVersion>1.1</VendorModelVersion><POSSequenceID>817</POSSequenceID><LoyaltySequenceID>0</LoyaltySequenceID></ResponseHeader><LoyaltyIDValidFlagvalue=""yes"" /><LoyaltyIDRegisteredvalue=""yes""/><PointInfo><PointBalance>4</PointBalance><CollectionRatio>000000.010</CollectionRatio></PointInfo></GetRewardsResponse>";

            Console.WriteLine(IsValidXmlString(xml));

            xml = RemoveInvalidXmlChars(xml);
            Console.WriteLine(IsValidXmlString(xml));

            var a7 = xml;
            //string encod= xml.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;").Replace("'", "&apos;");
            string sub = xml.Substring(260, 21);
            char c = xml[278];
            char b = xml[279];

            char a = xml[280];
            char d = xml[281];
            Console.ReadLine();
        }
        static string RemoveInvalidXmlChars(string text)
        {
            var validXmlChars = text.Where(ch => XmlConvert.IsXmlChar(ch)).ToArray();
            return new string(validXmlChars);
        }

        static bool IsValidXmlString(string text)
        {
            try
            {
                XmlConvert.VerifyXmlChars(text);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
