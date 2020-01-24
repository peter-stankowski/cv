using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CV.Core.Models
{
    public class RazorConfig
    {
        public ControllerContext controllerContext;
        public string viewPath;
        public RazorLayoutView viewModel;
    }
}
