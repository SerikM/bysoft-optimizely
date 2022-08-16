using System;
using EPiServer.Core;
using Bysoft.Optimizely.Models.Pages;
using System.Collections.Generic;

namespace Bysoft.Optimizely.Models.ViewModels
{
    public class ListingBlockViewModel
    {
        public virtual string Heading { get; set; }

        public virtual PageReference Parent { get; set; }


        public LayoutModel Layout { get; set; }
        public IContent Section { get; set; }
        public SitePageData StartPage { get; set; }
        public IEnumerable<SitePageData> MenuPages { get; set; }
    }
}
