
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV.Core.Transformers;
using CV.Core.Interfaces;
using CV.Core.Models;

namespace PeterStankowski.Controllers
{
    public class HomeController : Controller
    {
        //UnityConfig.cs
        private IXmlLayout service;
        private IRazorLayout rservice;
        public HomeController(IXmlLayout _service, IRazorLayout _rservice)
        {
            // unity throws an exception if DI missing in the confing file.
            service = _service;
            rservice = _rservice;
        }
        public HomeController()
        {
        }


        // GET: Home
        public ActionResult Index()
        {
            var html = service.RenderPage(
                new XmlConfig()
                {
                    dataPath = Server.MapPath("~/Templates/Peter.xml"),
                    templatePath = Server.MapPath("~/Templates/xslt2/Default.xslt")
                }
            );


            var razor = rservice.RenderPage(new RazorConfig()
            {
                controllerContext = this.ControllerContext,
                viewPath = "~/Templates/razor/Default.cshtml",
                viewModel = new RazorLayoutView().Seed()
            });



            var uglyHtml = NUglify.Uglify.Html(html);

            return View((object)uglyHtml.Code);
        }



    }
}