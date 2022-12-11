using DevTubeCommerce.Domain.Core.Base;
using DevTubeCommerce.Domain.Core.Catalogs.Products.Events;
using DevTubeCommerce.Domain.Core.Shared;

namespace DevTubeCommerce.Domain.Core.Catalogs.Products;

public class Product : AggregateRoot<ProductId>
{
    public string Title { get; private set; } = null!;
    public string? Description { get; private set; }
    public string Code { get; private set; } = null!;
    public double Price { get; private set; }
    private readonly List<ProductFeatureValue> _productFeatureValues = new List<ProductFeatureValue>();
    public IReadOnlyList<ProductFeatureValue> ProductFeatureValues => _productFeatureValues;

    internal static Product CreateNew(string title, string description, string code, double price, List<ProductFeatureValueData> productFeatures)
    {
        return new Product(title, description, code, price, productFeatures);
    }

    private void BuildFeatures(List<ProductFeatureValueData> featureData)
    {
        featureData.ForEach(feature =>
        {
            var newFeature = ProductFeatureValue.CreateNew(Id, feature.FeatureId, feature.Value);
            _productFeatureValues.Add(newFeature);
        });
    }

    private Product(string title, string description, string code, double price, List<ProductFeatureValueData> productFeatures)
    {
        if (price < 0) throw new BusinessRuleException("invalid price value");
        Title = title;
        Code = code;
        Description = description;
        Price = price;
        BuildFeatures(productFeatures);
        AddDomainEvent(new AddProductSendNotificationEvent(Id));
    }

    private Product() { }
}
