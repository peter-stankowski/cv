using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;
using System.Xml.XPath;
using CV.Core.Interfaces;
using System.IO;
using System.Web;

namespace CV.Core.Transformers
{
    public class XmlTransformer : IXmlTransformer, IDisposable
    {
        XPathDocument _xmlDocument;
        XPathDocument xmlDocument
        {
            get
            {
                if (_xmlDocument == null)
                    throw new ArgumentNullException("Please load xml template using LoadTemplate function.");

                return _xmlDocument;
            }
            set
            {
                _xmlDocument = value;
            }
        }

        XslCompiledTransform _xslTransform;
        XslCompiledTransform xslTransform
        {
            get
            {
                if (_xslTransform == null) _xslTransform = new XslCompiledTransform();
                return _xslTransform;
            }
        }


        public void LoadData(string dataPath)
        {
            xmlDocument = new XPathDocument(dataPath);
        }

        public void LoadTemplate(string templatePath)
        {
            xslTransform.Load(templatePath);
        }

        public void TransformTemplate(out StringWriter writer)
        {
            writer = new StringWriter();
            xslTransform.Transform(xmlDocument, null, writer);
        }

        public string DecodeToString(StringWriter writer)
        {
            var decoded = HttpUtility.HtmlDecode(writer.ToString());

            return decoded;
        }

     

        public void Dispose()
        {
            _xmlDocument = null;
            _xslTransform = null;
        }

      
    }
}
