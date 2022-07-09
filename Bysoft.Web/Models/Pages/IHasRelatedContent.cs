using EPiServer.Core;

namespace Bysoft.Web.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
