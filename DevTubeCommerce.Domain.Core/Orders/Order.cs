using DevTubeCommerce.Domain.Core.Base;
using DevTubeCommerce.Domain.Core.Customers;
using DevTubeCommerce.Domain.Core.Shared;

namespace DevTubeCommerce.Domain.Core.Orders;

public class Order : AggregateRoot<OrderId>
{
    public CustomerId CustomerId { get; private set; } = null!;
    public DateTime CreateDate { get; private set; }
    public string OrderCode { get; private set; } = null!;
    public OrderStatus OrderStatus { get; private set; }
    public string OrderStatusRemark { get; private set; } = null!;
    public Address Address { get; private set; } = null!;

    private readonly List<OrderItem> _orderItems = new List<OrderItem>();
    public IReadOnlyList<OrderItem> OrderItems => _orderItems;

    internal static Order CreateNew(CustomerId customerId, string orderCode, string address, string postalCode, string phone, List<OrderItemData> orderItems)
    {
        return new Order(customerId, orderCode, address, postalCode, phone, orderItems);
    }

    internal static void Accept(OrderId orderId)
    {
        //?? Aggregate or DomainService
    }

    internal static void Reject(OrderId orderId, string rejectMessage)
    {
        //?? Aggregate or DomainService
    }


    private void BuildOrderItems(List<OrderItemData> orderItems)
    {
        foreach (var item in orderItems)
        {
            var orderItem = OrderItem.CreateNew(Id, item.ProductId, item.ItemCount, item.Price);
            _orderItems.Add(orderItem);
        }
    }

    private Order(CustomerId customerId, string orderCode, string address, string postalCode, string phone, List<OrderItemData> orderItems)
    {
        if (orderItems == null || orderItems.Count == 0) throw new BusinessRuleException("Order Items does not items!!!");
        CustomerId = customerId;
        OrderCode = orderCode;
        CreateDate = DateTime.Now;
        OrderStatus = OrderStatus.Registered;
        Address = Address.CreateNew(address, postalCode, phone);
        BuildOrderItems(orderItems);
        //call events
    }
    private Order()
    {

    }

}
