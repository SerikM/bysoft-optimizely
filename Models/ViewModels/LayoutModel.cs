using System.Web;
using System.Web.Mvc;
using Bysoft.Optimizely.Models.Blocks;
using EPiServer.SpecializedProperties;

namespace Bysoft.Optimizely.Models.ViewModels
{
    public class LayoutModel
    {
        public SiteLogotypeBlock Logotype { get; set; }
        public IHtmlString LogotypeLinkUrl { get; set; }
        public bool HideHeader { get; set; }
        public bool HideFooter { get; set; }
        public bool LoggedIn { get; set; }
        public MvcHtmlString LoginUrl { get; set; }
        public MvcHtmlString LogOutUrl { get; set; }
        public MvcHtmlString SearchActionUrl { get; set; }

        public bool IsInReadonlyMode {get;set;}
    }
}
