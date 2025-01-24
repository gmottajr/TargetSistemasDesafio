using Microsoft.AspNetCore.Mvc;
using GmKitchenOrderFlow.Application;
using GmKitchenOrderFlow.Application.Models;

namespace GmKitchenOrderFlow.WebApi;

[ApiController]
[Route("api/[controller]")]
public class QueueController : KitchenFlowBaseController<QueueDto, long>
{
    public QueueController(IQueueAppService applicationService) : base(applicationService)
    {
    }
}
