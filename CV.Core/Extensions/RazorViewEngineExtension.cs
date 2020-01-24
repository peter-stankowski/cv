using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CV.Core.Extensions
{
    public class RazorViewEngineExtension: RazorViewEngine
    {

        public RazorViewEngineExtension()
        {
            var viewLocations = new[] {
            "~/Templates/razor/{0}.cshtml"
        };

            this.PartialViewLocationFormats = viewLocations;
        }

    }
}
