using ChatterServiceApi.Models.Dto;

namespace ChatterServiceApi.Repository.Interfaces;

public interface IChatterRepository
{
    Task<IEnumerable<ChatterDto>> GetChatters();
    Task<ChatterDto> GetChatterById(int id);
    Task<IEnumerable<ChatterDto>> GetByFieldContains(string value);
    Task<ChatterDto> CreateUpdateChatter(ChatterDto chatter);
    Task<bool> DeleteChatter(int id);
}