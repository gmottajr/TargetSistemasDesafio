using GmKitchenOrderFlow.DAL.Abstractions;
using GmKitchenOrderFlow.Domain;

namespace GmKitchenOrderFlow.DAL;

public interface IOrderRepository : IDataRepositoryBase<Order, long>
{

}