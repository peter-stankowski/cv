using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using CV.Core.Interfaces;
using CV.Core.Models;

namespace CV.Core.Transformers
{
    public class RazorTransformer : IRazorTransformer
    {
        ControllerContext _context;
        ControllerContext context
        {
            get
            {
                if (_context == null) throw new ArgumentNullException("ControllerContext is missing. Please call SetControllerContext function first.");
                return _context;

            }
        }

        ViewEngineResult _viewEngineResult;
        ViewEngineResult viewEngineResult
        {
            get
            {
                if (_viewEngineResult == null) throw new ArgumentNullException("ViewEngineResult is null. Please call LoadTemplate function first.");
                return _viewEngineResult;
            }
            set
            {
                _viewEngineResult = value;
            }
        }
        IView view;

       
        public void LoadTemplate(string templatePath)
        {
            viewEngineResult = ViewEngines.Engines.FindPartialView(context, templatePath);

            if (viewEngineResult == null)
                throw new FileNotFoundException($"View cannot be found. Path: {templatePath}");

        }
        public void AttachModel(RazorLayoutView model)
        {
            // get the view and attach the model to view data
            view = viewEngineResult.View;
            context.Controller.ViewData.Model = model;
        }


        public void TransformTemplate(out StringWriter writer)
        {
            using (var sw = new StringWriter())
            {
                var ctx = new ViewContext(context, view,
                                            context.Controller.ViewData,
                                            context.Controller.TempData,
                                            sw);
                view.Render(ctx, sw);
                writer = sw;
            }
        }

        public string DecodeToString(StringWriter writer)
        {
            return writer.ToString();
        }

        public ControllerContext SetControllerContext(ControllerContext context)
        {
            _context = context;

            return _context;
        }

       
    }
}
