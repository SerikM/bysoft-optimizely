using Bysoft.Optimizely.Models.Pages;
using Bysoft.Optimizely.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bysoft.Optimizely.Controllers
{
    public class StandardPageController : PageControllerBase<StandardPage>
    {
        private readonly IContentLoader _contentLoader;
        public StandardPageController(IContentLoader contentLoader)  
        {
            _contentLoader = contentLoader;
        }

        public ActionResult Index(StandardPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);

            model.StartPage = _contentLoader.Get<StartPage>(ContentReference.StartPage);
            model.MenuPages = FilterForVisitor
                .Filter(_contentLoader.GetChildren<SitePageData>(ContentReference.StartPage))
                .Cast<SitePageData>()
                .Where(p => p.VisibleInMenu);

            return View(model);
        }
    }
}