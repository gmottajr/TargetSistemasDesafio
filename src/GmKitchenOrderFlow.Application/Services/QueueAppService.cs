using GmKitchenOrderFlow.Application.Models;
using GmKitchenOrderFlow.DAL;
using GmKitchenOrderFlow.Domain;


namespace GmKitchenOrderFlow.Application.Services;

public class QueueAppService : AppServiceBase<QueueDto, Queue, long>, IQueueAppService
{
    public QueueAppService(IQueueRepository repository) : base(repository)
    {
    }
}
