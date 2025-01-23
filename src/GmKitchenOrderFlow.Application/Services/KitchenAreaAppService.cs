using GmKitchenOrderFlow.DAL;
using GmKitchenOrderFlow.Domain;
using GmKitchenOrderFlow.Application.Models;

namespace GmKitchenOrderFlow.Application.Services;

public class KitchenAreaAppService : AppServiceBase<KitchenAreaDto, KitchenArea, long>, IKitchenAreaAppService
{
    public KitchenAreaAppService(IKitchenAreaRepository repository) : base(repository)
    {
    }
}
