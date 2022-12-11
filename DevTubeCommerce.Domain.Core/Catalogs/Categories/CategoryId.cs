using DevTubeCommerce.Domain.Core.Base;

namespace DevTubeCommerce.Domain.Core.Catalogs.Categories;

public sealed class CategoryId : StronglyTypedId<CategoryId>
{
    public CategoryId(Guid value) : base(value)
    {
    }
}
