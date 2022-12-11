using DevTubeCommerce.Domain.Core.Base;
using DevTubeCommerce.Domain.Core.Catalogs.Features;

namespace DevTubeCommerce.Domain.Core.Catalogs.Categories;

public class Category : AggregateRoot<CategoryId>
{
    public string CategoryName { get; private set; } = null!;
    public bool IsActive { get; private set; }
    public string Description { get; private set; } = null!;

    private readonly List<CategoryFeature> _categoryFeatures = new List<CategoryFeature>();
    public IReadOnlyList<CategoryFeature> CategoryFeatures => _categoryFeatures;


    internal static Category CreateNew(string categoryName, bool isActive, string description, List<FeatureId> features)
    {
        return new Category(categoryName, isActive, description, features);
    }

    private void BuildFeatures(List<FeatureId> featureData)
    {
        featureData.ForEach(featureId =>
        {
            var newFeature = CategoryFeature.CreateNew(Id, featureId);
            _categoryFeatures.Add(newFeature);
        });
    }

    private Category(string categoryName, bool isActive, string description, List<FeatureId> features)
    {
        //validation....
        CategoryName = categoryName;
        IsActive = isActive;
        Description = description;
        BuildFeatures(features);
    }

    private Category()
    {
    }
}
