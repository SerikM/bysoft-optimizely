using System.Web.Mvc;
using Bysoft.Optimizely.Models.Pages;
using Bysoft.Optimizely.Models.ViewModels;
using EPiServer.Web.Mvc;
using EPiServer.Shell.Security;
using Bysoft.Optimizely.Business;

namespace Bysoft.Optimizely.Controllers
{
    /// <summary>
    /// All controllers that renders pages should inherit from this class so that we can
    /// apply action filters, such as for output caching site wide, should we want to.
    /// </summary>
    public abstract class PageControllerBase<T> : PageController<T>, IModifyLayout
        where T : SitePageData
    {
        public virtual void ModifyLayout(LayoutModel layoutModel)
        {
            var page = PageContext.Page as SitePageData;
            if (page != null)
            {
                layoutModel.HideHeader = page.HideSiteHeader;
                layoutModel.HideFooter = page.HideSiteFooter;
            }
        }

    }
}
