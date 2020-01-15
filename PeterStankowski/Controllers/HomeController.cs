using PeterStankowski.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeterStankowski.Controllers
{
    public class HomeController : Controller
    {

        //UnityConfig.cs
        private ILayoutService service;
        public HomeController(ILayoutService _service)
        {
            service = _service;
            if (service == null)
                throw new ArgumentNullException("ILayoutService is null, check UnityConfig.cs");

            // set XSLT template server path
            service.XsltTemplatePath = System.Web.HttpContext.Current.Server.MapPath("~/Templates/xslt/Default.xslt");
        }


        // GET: Home
        public ActionResult Index()
        {
            string xml = Server.MapPath("~/Templates/Empty.xml");

            var html = service.GetPage(xml);
            var uglyHtml = NUglify.Uglify.Html(html);

            return View((object)uglyHtml.Code);
        }

        
    }
}