using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using CV.Core.Extensions;
using CV.Core.Models;
using CV.Core.Interfaces;
using System.IO;

namespace CV.Core.Transformers
{
    public class RazorLayout : IRazorLayout
    {

        IRazorTransformer transformer;
        public RazorLayout(IRazorTransformer _transformer)
        {
            transformer = _transformer;
        }

        public string RenderPage(RazorConfig config)
        {
            StringWriter writer;
            transformer.SetControllerContext(config.controllerContext);
            transformer.LoadTemplate(config.viewPath);
            transformer.AttachModel(config.viewModel);
            transformer.TransformTemplate(out writer);

            var html = transformer.DecodeToString(writer);

            return html;
        }

      
    }
}
