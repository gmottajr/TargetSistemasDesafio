using GmKitchenOrderFlow.Application.Models;
using GmKitchenOrderFlow.Domain;
using GmKitchenOrderFlow.Application.Models;

namespace GmKitchenOrderFlow.Application;

public interface IQueueAppService : IAppServiceBase<QueueDto, Queue, long>
{

}
