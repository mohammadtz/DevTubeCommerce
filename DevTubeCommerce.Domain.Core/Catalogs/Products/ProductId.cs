using DevTubeCommerce.Domain.Core.Base;

namespace DevTubeCommerce.Domain.Core.Catalogs.Products;

public sealed class ProductId : StronglyTypedId<ProductId>
{
    public ProductId(Guid value) : base(value)
    {

    }
}
