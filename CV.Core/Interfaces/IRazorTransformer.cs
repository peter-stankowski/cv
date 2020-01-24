using CV.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CV.Core.Interfaces
{
    public interface IRazorTransformer : ITransformer
    {
        void SetControllerContext(ControllerContext context);
        void AttachModel(RazorLayoutView model);

    }
}
