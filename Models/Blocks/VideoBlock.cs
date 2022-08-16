using EPiServer;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bysoft.Optimizely.Models.Blocks
{
    [ContentType(
        GUID = "8f4dd88f-42f0-42f3-a130-96c433508598",
        GroupName = Constants.GroupNames.Default)]
    [ImageUrl("~/Static/gfx/page-type-thumbnail.png")]
    public class VideoBlock : BlockData
    {
        [DefaultDragAndDropTarget]
        [UIHint(UIHint.Video)]
        public virtual Url Video { get; set; }

        public virtual string Title { get; set; }

        public virtual XhtmlString LeftSideContent { get; set; }
    }
}