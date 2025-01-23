using GmKitchenOrderFlow.DAL.Abstractions;
using GmKitchenOrderFlow.Domain;
using Microsoft.EntityFrameworkCore;

namespace GmKitchenOrderFlow.DAL;

public class QueueRepository : DataRepositoryBase<Queue, long>, IQueueRepository
{
    public QueueRepository(DbContextKitchen context) : base(context)
    {
    }
}
