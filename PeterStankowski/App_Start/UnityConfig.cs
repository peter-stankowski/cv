
using CV.Core.Interfaces;
using CV.Core.Transformers;
using CV.Core.Models;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace PeterStankowski
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IXmlLayout, XmlLayout>();
            container.RegisterType<IRazorLayout, RazorLayout>();

            //container.RegisterType<ILayout<RazorConfig>, RazorLayout>();
            container.RegisterType<IXmlTransformer, XmlTransformer>();
            container.RegisterType<IRazorTransformer, RazorTransformer>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}