using System.ComponentModel.DataAnnotations;
using Bysoft.Optimizely.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Bysoft.Optimizely.Models.Pages
{
    [ContentType(
        DisplayName = "Start Page", 
        GUID = "19671657-B684-4D95-A61F-8DD4FE60D559", 
        GroupName = Constants.GroupNames.Specialized,
        Description = "use this page type for the start page.")]
    [ImageUrl(Constants.StaticGraphicsFolderPath + "page-type-thumbnail-standard.png")]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage), typeof(ServicePage)})]
    public class StartPage : SitePageData
    {
        [Display(GroupName = SystemTabNames.Content, Order = 320)]
        [CultureSpecific]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(GroupName = Constants.GroupNames.SiteSettings)]
        public virtual PageReference SearchPageLink { get; set; }

        [Display(GroupName = Constants.GroupNames.SiteSettings)]
        public virtual SiteLogotypeBlock SiteLogotype { get; set; }

        [Display(GroupName = Constants.GroupNames.SiteSettings)]
        public virtual PageReference ServicePageLink { get; set; }
    }
}
