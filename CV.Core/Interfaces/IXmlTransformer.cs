using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace CV.Core.Interfaces
{
    public interface IXmlTransformer: ITransformer
    {
        void LoadData(string dataPath);
    }
}
