using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Bysoft.Optimizely;
using EPiServer.Shell.ObjectEditing;
using Bysoft.Optimizely.Business.SelectionFactories;

namespace Bysoft.Optimizely.Models.Pages
{
    [ContentType(
        DisplayName = "Standard", 
        GUID = "9CCC8A41-5C8C-4BE0-8E73-520FF3DE8267",
        GroupName = Constants.GroupNames.Specialized,
        Description = "use this page type unless you need a more specialized one.")]
    [ImageUrl(Constants.StaticGraphicsFolderPath + "page-type-thumbnail-standard.png")]
    [AvailableContentTypes(Include = new[] { typeof(StandardPage) })]
    public class StandardPage : SitePageData
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

        [SelectOne(SelectionFactoryType = typeof(ThemeSelectionFactory))]
        [Display(
            Name = "Theme selector",
            Description = "Use this property to change theme of the page",
            GroupName = SystemTabNames.Content, Order = 1)]
        [Required]
        public virtual string Theme { get; set; }
    }
}