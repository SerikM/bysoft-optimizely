using EPiServer.Core;

namespace Bysoft.Optimizely.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
