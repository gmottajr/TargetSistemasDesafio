using GmKitchenOrderFlow.Domain;
using Microsoft.EntityFrameworkCore;

namespace GmKitchenOrderFlow.DAL;

public class OrderRepository : DataRepositoryBase<Order, long>, IOrderRepository
{
    public OrderRepository(DbContextKitchen context) : base(context)
    {
    }
}
