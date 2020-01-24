using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Core.Interfaces
{
    public interface ILayout<T> where T: class
    {
        /// <summary>
        /// Renders as string based on given config
        /// </summary>
        /// <param name="config">Layout config options</param>
        /// <returns>string</returns>
        string RenderPage(T config);
    }
}
