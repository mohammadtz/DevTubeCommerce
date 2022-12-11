namespace DevTubeCommerce.Application.Contract.Dto.Catalog;

public class FeatureDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public int SortOrder { get; set; }
}
