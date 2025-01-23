namespace GmKitchenOrderFlow.Domain.Abstractions;

public abstract class EntityBaseRoot<TKey> : EntityBase
{
    public required TKey Id { get; set; }
}

