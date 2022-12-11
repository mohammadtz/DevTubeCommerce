using DevTubeCommerce.Domain.Core.Base;
using DevTubeCommerce.Domain.Core.Shared;

namespace DevTubeCommerce.Domain.Core.Customers;

public class Customer : AggregateRoot<CustomerId>
{
    public string FirstName { get; private set; } = null!;
    public string LastName { get; private set; } = null!;
    public string Mobile { get; private set; } = null!;

    private readonly List<AddressInfo> _addressInfos = new List<AddressInfo>();
    public IReadOnlyList<AddressInfo> AddressInfos => _addressInfos;

    internal static Customer CreateNew(string firstName, string lastName, string mobile, List<AddressInfoData> addressList)
    {
        return new Customer(firstName, lastName, mobile, addressList);
    }

    private void BuildAddressInfos(List<AddressInfoData> addressList)
    {
        foreach (var item in addressList)
        {
            var addressInfo = AddressInfo.CreateNew(Id, item.PostalCode, item.Address, item.Title);
            _addressInfos.Add(addressInfo);
        }
    }

    public Customer(string firstName, string lastName, string mobile, List<AddressInfoData> addressList)
    {
        FirstName = firstName;
        LastName = lastName;
        Mobile = mobile;
        BuildAddressInfos(addressList);
    }

    private Customer()
    {

    }
}
