using GmKitchenOrderFlow.Application.Models;
using GmKitchenOrderFlow.DAL;
using GmKitchenOrderFlow.Domain;

namespace GmKitchenOrderFlow.Application.Services;

public class OrderAppService : AppServiceBase<OrderDto, Order, long>, IOrderAppService
{
    public OrderAppService(IOrderRepository repository) : base(repository)
    {
    }
}
