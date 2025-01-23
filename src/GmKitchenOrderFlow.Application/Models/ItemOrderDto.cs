using System.ComponentModel.DataAnnotations;
using GmKitchenOrderFlow.Domain.enums;
using GmKitchenOrderFlow.Application.Models.Abstractions;
namespace GmKitchenOrderFlow.Application.Models
{
    public class ItemOrderDto: ResourceDtoBase
    {
        [Required]
        public long MenuItemMealId { get; set; }
        [Required]
        public long OrderId { get; set; }
        [Required]
        public short Quantity { get; set; }
        public ItemOrderStatusEnum Status { get; set; }
        public QueueDto? QueueCurrent { get; set; }
        public long? QueueCurrentId { get; set; }
        public List<QueueDto>? Queues { get; set; }
    }
}
