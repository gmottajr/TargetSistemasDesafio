using GmKitchenOrderFlow.Domain;
using Microsoft.EntityFrameworkCore;

namespace GmKitchenOrderFlow.DAL;

public class KitchenAreaRepository : DataRepositoryBase<KitchenArea, long>, IKitchenAreaRepository
{
    public KitchenAreaRepository(DbContextKitchen context) : base(context)
    {
    }
}
