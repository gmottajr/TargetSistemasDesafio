using Microsoft.AspNetCore.Mvc;
using GmKitchenOrderFlow.Application;
using GmKitchenOrderFlow.Application.Models;


namespace GmKitchenOrderFlow.WebApi;


[ApiController]
[Route("api/kitchen-areas")]
public class KitchenAreaController : KitchenFlowBaseController<KitchenAreaDto, long>
{
    public KitchenAreaController(IKitchenAreaAppService applicationService) : base(applicationService)
    {
    }
    
}
