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
    public class ThemeSelectionFactory : EPiServer.Shell.ObjectEditing.ISelectionFactory
    {
        private Injected<ContentLocator> ContentLocator { get; set; }

        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new List<SelectItem>
            {
            new SelectItem { Value = "theme1", Text = "Theme 1" },
            new SelectItem { Value = "theme1", Text = "Theme 2" },
            new SelectItem { Value = "theme1", Text = "Theme 3" },
            };
        }
    }
}