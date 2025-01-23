using GmKitchenOrderFlow.Application.Models;
using GmKitchenOrderFlow.Domain;
namespace GmKitchenOrderFlow.Application;

public interface IKitchenAreaAppService : IAppServiceBase<KitchenAreaDto, KitchenArea, long>
{

}