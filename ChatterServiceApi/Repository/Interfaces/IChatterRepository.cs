using ChatterServiceApi.Models;
using ChatterServiceApi.Models.Dto;

namespace ChatterServiceApi.Repository.Interfaces;

public interface IChatterRepository
{
    Task<IEnumerable<AbstractChatter>> GetAllChatters();
    Task<ChatterDto> GetChatterById(int id);
    Task<IEnumerable<ChatterDto>> GetByFieldContains(string value);
    Task<ChatterDto> CreateUpdateChatter(ChatterDto chatter);
    Task<bool> DeleteChatter(int id);
}