using GmKitchenOrderFlow.Application.Models;
using GmKitchenOrderFlow.Domain;

namespace GmKitchenOrderFlow.Application;

public interface IOrderAppService : IAppServiceBase<OrderDto, long>
{

}
