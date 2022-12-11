namespace DevTubeCommerce.Domain.Core.Shared;

public record class AddressInfoData
{
    public string PostalCode { get; init; } = null!;
    public string Address { get; init; } = null!;
    public string Title { get; init; } = null!;
}
