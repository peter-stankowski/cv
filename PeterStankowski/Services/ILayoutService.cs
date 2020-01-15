using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterStankowski.Services
{
    public interface ILayoutService
    {
        string XsltTemplatePath { get; set; } // xslt template server path
        string GetPage(string dataPath); // xml data server path

    }
}
