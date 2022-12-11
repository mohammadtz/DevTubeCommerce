using DevTubeCommerce.Domain.Core.Base;

namespace DevTubeCommerce.Domain.Core.Catalogs.Features;

public sealed class FeatureId : StronglyTypedId<FeatureId>
{
    public FeatureId(Guid value) : base(value)
    {

    }
}
