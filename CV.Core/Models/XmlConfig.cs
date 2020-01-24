using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Core.Models
{
    public class XmlConfig
    {
        /// <summary>
        /// Virtual template file path (e.g. "~/Templates/layout/filename.???")
        /// </summary>
        public string templatePath;

        /// <summary>
        /// Virtual data file path (e.g. "~/Templates/data/filename.???")
        /// </summary>
        public string dataPath;
    }
}
