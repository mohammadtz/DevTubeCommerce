using DevTubeCommerce.Domain.Core.Catalogs.Products.Events;
using MediatR;

namespace DevTubeCommerce.Domain.Core.Customers.Events;

public class AddNewProductNotificationHandler : INotificationHandler<AddProductSendNotificationEvent>
{
    public Task Handle(AddProductSendNotificationEvent notification, CancellationToken cancellationToken)
    {
        //send sms to All users
        return Task.FromResult(notification);
    }
}
