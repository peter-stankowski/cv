using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace PeterStankowski.Services
{
    public class XmlLayoutService : ILayoutService
    {
        public string XsltTemplatePath { get; set; }

        public string GetPage(string dataPath)
        {
            if (XsltTemplatePath == null) throw new ArgumentNullException("Missing xslt template path. Set XsltTemplatePath for ILayoutService in controller's constructor");

            string xsl = XsltTemplatePath;
            string xml = dataPath;

            System.Xml.XPath.XPathDocument doc = new System.Xml.XPath.XPathDocument(xml);
            XslCompiledTransform trans = new System.Xml.Xsl.XslCompiledTransform();
           
            trans.Load(xsl);

            StringWriter writer = new StringWriter();
            trans.Transform(doc, null, writer);

            var decoded = HttpUtility.HtmlDecode(writer.ToString());

            return decoded.ToString();
        }
    }

    public class TestExtension
    {
        //public XPathNodeIterator GetRows()
        //{
        //    var test = new string[] { "test 1", "test 2", "Test 3" };

        //    XmlDocument doc = new XmlDocument();

        //    XElement xmlElements = new XElement("testarray", test.Select(i => new XElement("test", i)));

        //    return doc.CreateNavigator().Select();
        //}
    }
}