using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bysoft.Optimizely.Models.Pages
{
    /// <summary>
    /// Used to present a single product
    /// </summary>
    [ContentType(
        DisplayName = "Service Page",
        GUID = "17583DCD-3C11-49DD-A66D-0DEF0DD601FC", 
        GroupName = Constants.GroupNames.Services,
        Description = "use this page type for display of available services and products.")]
    [ImageUrl(Constants.StaticGraphicsFolderPath + "page-type-thumbnail-service.png")]
    [AvailableContentTypes(Include = new[] { typeof(ServicePage) })]
    public class ServicePage : SitePageData//, IHasRelatedContent
    {
        [CultureSpecific]
        [Display(
           Name = "Main body",
           Description = "The main body will be shown in the main content area of the page",
           GroupName = SystemTabNames.Content, Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
             Name = "Main content area",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}