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
    public class XmlLayoutService : IXmlLayoutService
    {

        public string GetXmlPage(string templatePath, string dataPath)
        {
            if (templatePath == null)
                throw new ArgumentNullException("Missing xslt template path. Set XsltTemplatePath for ILayoutService in controller's constructor");

            string xsl = templatePath;
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

}