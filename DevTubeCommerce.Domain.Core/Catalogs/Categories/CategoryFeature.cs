using DevTubeCommerce.Domain.Core.Base;
using DevTubeCommerce.Domain.Core.Catalogs.Features;

namespace DevTubeCommerce.Domain.Core.Catalogs.Categories;

public class CategoryFeature : Entity<Guid>
{
    public CategoryId? CategoryId { get; private set; }
    public FeatureId? FeatureId { get; private set; }

    internal static CategoryFeature CreateNew(CategoryId categoryId, FeatureId featureId)
    {
        return new CategoryFeature(categoryId, featureId);
    }

    private CategoryFeature(CategoryId categoryId, FeatureId featureId)
    {
        CategoryId = categoryId;
        FeatureId = featureId;
    }

    private CategoryFeature()
    {

    }
}
