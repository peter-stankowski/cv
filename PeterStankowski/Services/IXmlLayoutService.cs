using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeterStankowski.Services
{
    public interface IXmlLayoutService
    {
        /// <summary>
        /// Transforms XML data file using provided XSLT template
        /// </summary>
        /// <param name="templatePath">Server path pointing to the location of the .xslt template file</param>
        /// <param name="dataPath">Server path pointing to the location of the .xml data file</param>
        /// <returns>html string</returns>
        string GetXmlPage(string templatePath, string dataPath);
    }
}