using DevTubeCommerce.Domain.Core.Base;

namespace DevTubeCommerce.Domain.Core.Catalogs.Products.Events;

public record class AddProductSendNotificationEvent : DomainEvent
{
    public ProductId ProductId { get; init; }

    public AddProductSendNotificationEvent(ProductId productId)
    {
        ProductId = productId;
        AggregateId = productId.Value;
    }
}
