using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CV.Core.Interfaces;
using CV.Core.Models;

namespace CV.Core.Transformers
{
    public class XmlLayout : IXmlLayout
    {
        IXmlTransformer xmlTransformer;
        public XmlLayout(IXmlTransformer _xmlTransformer)
        {
            xmlTransformer = _xmlTransformer;
        }

        public string RenderPage(XmlConfig config)
        {
            if (config.templatePath == null)
                throw new ArgumentNullException("Missing xslt template path. Set XsltTemplatePath for ILayoutService in controller's constructor");

            StringWriter writer;
            xmlTransformer.LoadData(config.dataPath);
            xmlTransformer.LoadTemplate(config.templatePath);
            xmlTransformer.TransformTemplate(out writer);

            return xmlTransformer.DecodeToString(writer);
        }
    }
}
