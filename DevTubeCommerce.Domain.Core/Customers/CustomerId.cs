using DevTubeCommerce.Domain.Core.Base;

namespace DevTubeCommerce.Domain.Core.Customers;

public sealed class CustomerId : StronglyTypedId<CustomerId>
{
    public CustomerId(Guid value) : base(value)
    {
    }
}
