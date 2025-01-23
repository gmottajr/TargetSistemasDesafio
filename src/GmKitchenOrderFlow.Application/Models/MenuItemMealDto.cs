using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using GmKitchenOrderFlow.Application.Models;
using GmKitchenOrderFlow.Application.Models.Abstractions;

namespace GmKitchenOrderFlow.Application.Models;

public class MenuItemMealDto : ResourceDtoBaseRoot<long>
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public decimal Price { get; set; }

    public List<long>? Composition { get; set; }

    [Required]
    public List<MenuItemKitchenRoutingMapDto> KitchenRoutingMaps { get; set; }
}
