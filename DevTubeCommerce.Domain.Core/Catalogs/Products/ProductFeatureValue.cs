using DevTubeCommerce.Domain.Core.Base;
using DevTubeCommerce.Domain.Core.Catalogs.Features;

namespace DevTubeCommerce.Domain.Core.Catalogs.Products;

public class ProductFeatureValue : Entity<Guid>
{
    public ProductId ProductId { get; private set; } = null!;
    public FeatureId FeatureId { get; private set; } = null!;
    public string Value { get; private set; } = null!;

    internal static ProductFeatureValue CreateNew(ProductId productId, FeatureId featureId, string value)
    {
        return new ProductFeatureValue(productId, featureId, value);
    }

    private ProductFeatureValue(ProductId productId, FeatureId featureId, string value)
    {
        ProductId = productId;
        FeatureId = featureId;
        Value = value;
    }

    private ProductFeatureValue()
    {

    }
}
