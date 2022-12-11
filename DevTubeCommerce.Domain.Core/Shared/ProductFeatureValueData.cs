using DevTubeCommerce.Domain.Core.Catalogs.Features;

namespace DevTubeCommerce.Domain.Core.Shared;

public record class ProductFeatureValueData
{
    public FeatureId FeatureId { get; init; }
    public string Value { get; init; }

    public ProductFeatureValueData(FeatureId featureId, string value)
    {
        Value = value;
        FeatureId = featureId;
    }
}
