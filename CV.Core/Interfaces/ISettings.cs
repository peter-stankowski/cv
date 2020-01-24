using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Core.Interfaces
{
    public abstract class ISettings
    {
        private string _templatePath;
        /// <summary>
        /// Virtual template file path (e.g. "~/Templates/layout/filename.???")
        /// </summary>
        public virtual string TemplatePath
        {
            get
            {
                return _templatePath;
            }
            set
            {
                _templatePath = value;
            }
        }

        private string _dataPath;
        /// <summary>
        /// Virtual data file path (e.g. "~/Templates/data/filename.???")
        /// </summary>
        public virtual string DataPath
        {
            get
            {
                return _dataPath;
            }
            set
            {
                _dataPath = value;
            }
        }

    }
}
