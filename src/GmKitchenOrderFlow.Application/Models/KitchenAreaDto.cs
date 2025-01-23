using System.ComponentModel.DataAnnotations;
using GmKitchenOrderFlow.Domain.enums;
using GmKitchenOrderFlow.Application.Models.Abstractions;
namespace GmKitchenOrderFlow.Application.Models;

public class KitchenAreaDto : ResourceDtoBaseRoot<long>
{
    [Required]
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;

    [Required]
    public KitchenStatusEnum Status { get; set; } = KitchenStatusEnum.Open;

    public QueueDto? Queue { get; set; }

    [Required]
    public long QueueId { get; set; } 
}
