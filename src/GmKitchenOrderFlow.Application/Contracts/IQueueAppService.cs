using GmKitchenOrderFlow.Application.Models;
using GmKitchenOrderFlow.Domain;
namespace GmKitchenOrderFlow.Application;

public interface IQueueAppService : IAppServiceBase<QueueDto, Queue, long>
{

}
