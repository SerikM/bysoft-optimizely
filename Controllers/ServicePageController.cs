using Bysoft.Optimizely.Models.Pages;
using Bysoft.Optimizely.Models.ViewModels;
using EPiServer;
using EPiServer.Framework.DataAnnotations;
using System;
using System.Web.Mvc;

namespace Bysoft.Optimizely.Controllers
{

    [TemplateDescriptor(Default = true, Inherited = true)]
    public class ServicePageController : PageControllerBase<ServicePage>
    {
        public ViewResult Index(ServicePage currentPage)
        {
            var model = CreateModel(currentPage);
            return View(model);
        }

        public ViewResult Details(ServicePage currentPage)
        {
            var model = CreateModel(currentPage);
            return View(model);
        }


        private static IPageViewModel<SitePageData> CreateModel(ServicePage page)
        {
            var type = typeof(PageViewModel<>).MakeGenericType(page.GetOriginalType());
            return Activator.CreateInstance(type, page) as IPageViewModel<SitePageData>;
        }
    }
}