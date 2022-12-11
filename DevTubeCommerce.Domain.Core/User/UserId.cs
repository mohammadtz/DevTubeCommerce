using DevTubeCommerce.Domain.Core.Base;

namespace DevTubeCommerce.Domain.Core.User;

public sealed class UserId : StronglyTypedId<UserId>
{
    public UserId(Guid value) : base(value)
    {
    }
}
