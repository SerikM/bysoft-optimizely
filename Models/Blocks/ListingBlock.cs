using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bysoft.Optimizely.Models.Blocks
{
    [ContentType(DisplayName = "Listing Block", GUID = "95173723-de66-482b-bde5-229b4aadfe50", Description = "Use this content type to display children of a page")]
    [ImageUrl(Constants.StaticGraphicsFolderPath + "page-type-thumbnail-standard.png")]
    public class ListingBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Parent",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual PageReference Parent { get; set; }
    }
}