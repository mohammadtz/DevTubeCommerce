using MediatR;

namespace DevTubeCommerce.Domain.Core.Base;

public interface IDomainEvent : INotification
{
}

public abstract record class Message
{
    public string MessageType { get; init; }
    public Guid AggregateId { get; init; }

    protected Message()
    {
        MessageType = GetType().FullName ?? string.Empty;
    }
}

public abstract record class DomainEvent : Message, IDomainEvent
{
    public DateTime CreatedAt { get; init; }

    public DomainEvent()
    {
        CreatedAt = DateTime.Now;
    }
}
