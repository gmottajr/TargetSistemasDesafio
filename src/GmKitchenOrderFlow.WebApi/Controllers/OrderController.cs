using Microsoft.AspNetCore.Mvc;
using GmKitchenOrderFlow.Application;
using GmKitchenOrderFlow.Application.Models;

namespace GmKitchenOrderFlow.WebApi;

public class OrderController : KitchenFlowBaseController<OrderDto, long>
{
    public OrderController(IOrderAppService applicationService) : base(applicationService)
    {
    }
}
