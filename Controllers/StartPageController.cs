using System.Web.Mvc;
using Bysoft.Optimizely.Models.Pages;
using Bysoft.Optimizely.Models.ViewModels;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace Bysoft.Optimizely.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            
            var model = PageViewModel.Create(currentPage);

            return View(model);
        }

    }
}
