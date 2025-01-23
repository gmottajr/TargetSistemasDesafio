using GmKitchenOrderFlow.Application.Models;
using GmKitchenOrderFlow.Domain.Abstractions;
using GmKitchenOrderFlow.DAL.Abstractions;
using GmKitchenOrderFlow.Application.Models.Abstractions;

namespace GmKitchenOrderFlow.Application;

public interface IAppServiceBase<TDto, TEntity, TKey> where TDto : IResourceDtoBase where TEntity : EntityBaseRoot<TKey>
{
    Task<TDto> GetByIdAsync(TKey id);
    Task<IEnumerable<TDto>> GetAllAsync();
    Task<TDto> AddAsync(TDto dto);
    Task<TDto> UpdateAsync(TDto dto);
    Task DeleteAsync(TKey id);
}
