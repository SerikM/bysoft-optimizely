using EPiServer.Personalization.VisitorGroups;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;
using System.Linq;

namespace Bysoft.Optimizely.Business.SelectionFactories
{
    /// <summary>
    /// Provides a list of options corresponding to ServicePage pages on the site
    /// </summary>
    /// <seealso cref="ServicePageSelector"/>
    public class ServicePageSelectionFactory : EPiServer.Shell.ObjectEditing.ISelectionFactory
    {
        private Injected<ContentLocator> ContentLocator { get; set; }

        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var servicePages = ContentLocator.Service.GetServicePages();

            return new List<SelectItem>(servicePages.Select(c => new SelectItem { Value = c.PageLink, Text = c.Name }));
        }
    }
}