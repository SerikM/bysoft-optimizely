using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Bysoft.Optimizely.Models.Blocks
{
    [ContentType(DisplayName = "Hero Banner Block", GUID = "54c313dc-6b1e-4226-82df-5fde1e25c52c", Description = "Use this content type for hero banners")]
    public class HeroBannerBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title on top of the banner",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Overlay Text",
           Description = "This is the small text underneath the title",
           GroupName = SystemTabNames.Content,
           Order = 2)]
        public virtual string OverlayText { get; set; }

        [Display(
           Name = "Background Image",
           Description = "This is the background image of the hero banner",
           GroupName = SystemTabNames.Content,
           Order = 3)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference BackgroundImage { get; set; }

    }
}