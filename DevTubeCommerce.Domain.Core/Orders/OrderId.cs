using DevTubeCommerce.Domain.Core.Base;

namespace DevTubeCommerce.Domain.Core.Orders;

public sealed class OrderId : StronglyTypedId<OrderId>
{
    public OrderId(Guid value) : base(value)
    {
    }
}
