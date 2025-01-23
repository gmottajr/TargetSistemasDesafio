using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using GmKitchenOrderFlow.Application.Models;
using GmKitchenOrderFlow.Application.Models.Abstractions;

namespace GmKitchenOrderFlow.Application.Models;

public class QueueDto : ResourceDtoBaseRoot<long>
{
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    public List<MenuItemKitchenRoutingMapDto> MenuItemRouted { get; set; } = new List<MenuItemKitchenRoutingMapDto>();
    public List<ItemOrderDto>? ItemOrders { get; set; }
    public long KitchenAreaId { get; set; }
}
