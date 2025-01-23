using System.ComponentModel.DataAnnotations;
using GmKitchenOrderFlow.Application;
using GmKitchenOrderFlow.Application.Models.Abstractions;

namespace GmKitchenOrderFlow.Application.Models
{
    public class MenuItemKitchenRoutingMapDto: ResourceDtoBase
    {
        [Required]
        public long MenuItemMealId { get; set; }
        [Required]
        public long KitchenAreaId { get; set; }
    }
}