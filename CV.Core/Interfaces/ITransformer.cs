using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Core.Interfaces
{
    public interface ITransformer
    {
        void LoadTemplate(string templatePath);
        void TransformTemplate(out StringWriter writer);
        string DecodeToString(StringWriter writer);
    }
}
