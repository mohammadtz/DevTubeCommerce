using DevTubeCommerce.Domain.Core.Base;

namespace DevTubeCommerce.Domain.Core.Orders;

public class Address : ValueObject<Address>
{
    public string CustomerAddress { get; private set; } = null!;
    public string PostalCode { get; private set; } = null!;
    public string Phone { get; private set; } = null!;

    internal static Address CreateNew(string customerAddress, string postalCode, string phone)
    {
        return new Address(customerAddress, postalCode, phone);
    }

    private Address(string customerAddress, string postalCode, string phone)
    {
        CustomerAddress = customerAddress;
        PostalCode = postalCode;
        Phone = phone;
    }

    private Address()
    {

    }

    protected override bool EqualsCore(Address other)
    {
        throw new NotImplementedException();
    }

    protected override int GetHashCodeCore()
    {
        throw new NotImplementedException();
    }
}
