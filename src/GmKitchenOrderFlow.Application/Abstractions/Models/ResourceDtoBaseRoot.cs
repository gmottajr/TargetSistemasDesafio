namespace GmKitchenOrderFlow.Application;

public class ResourceDtoBaseRoot<TKey> : ResourceDtoBase
{
    public TKey Id { get; set; }
}
