using DevTubeCommerce.Domain.Core.Base;
using DevTubeCommerce.Domain.Core.Catalogs.Products;

namespace DevTubeCommerce.Domain.Core.Orders;

public class OrderItem : Entity<Guid>
{
    public OrderId OrderId { get; private set; } = null!;
    public ProductId ProductId { get; private set; } = null!;
    public int ItemCount { get; private set; }
    public double Price { get; set; }

    internal static OrderItem CreateNew(OrderId orderId, ProductId productId, int itemCount, double price)
    {
        return new OrderItem(orderId, productId, itemCount, price);
    }

    private OrderItem(OrderId orderId, ProductId productId, int itemCount, double price)
    {
        OrderId = orderId;
        ProductId = productId;
        ItemCount = itemCount;
        Price = price;
    }

    private OrderItem()
    {

    }
}
