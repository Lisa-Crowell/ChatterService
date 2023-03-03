using AutoMapper;
using ChatterServiceApi.DbContext;
using ChatterServiceApi.Models;
using ChatterServiceApi.Models.Dto;
using ChatterServiceApi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ChatterServiceApi.Repository;

public class ChatterRepository : IChatterRepository
{
    private readonly ChatterServiceDbContext _db;
    private readonly IMapper _mapper;

    public ChatterRepository(ChatterServiceDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AbstractChatter>> GetAllChatters()
    {
        if (_db.Chatters != null) return await _db.Chatters.ToListAsync();
        return new List<AbstractChatter>();
    }

    public Task<ChatterDto> GetChatterById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ChatterDto>> GetByFieldContains(string value)
    {
        throw new NotImplementedException();
    }

    public Task<ChatterDto> CreateUpdateChatter(ChatterDto chatter)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteChatter(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<ChatterDto>> GetChatters()
    {
        if (_db.Chatters != null)
        {
            var chatterList = await _db.Chatters.ToListAsync();
            return _mapper.Map<List<ChatterDto>>(chatterList);
        }

        return new[] {new ChatterDto()};
    }
}