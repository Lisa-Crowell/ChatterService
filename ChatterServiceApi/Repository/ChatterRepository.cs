using System.Collections;
using AutoMapper;
using ChatterServiceApi.DbContext;
using ChatterServiceApi.Models.Dto;
using ChatterServiceApi.Repository.Interfaces;

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
    
    public async Task<IEnumerable<ChatterDto>> GetChatters()
    {
        var chatterList = await _db.Chatters.ToListAsync();
        return _mapper.Map<List<ChatterDto>>(chatterList);
    }

    public async Task<ChatterDto> GetChatterById(int id)
    {
        var chatter = await _db.Chatters.FirstOrDefaultAsync(x => x.Id == id);
        return _mapper.Map<ChatterDto>(chatter);
    }

    public Task<IEnumerable<ChatterDto>> GetByFieldContains(string value)
    {
        var chatterList = _db.Chatters.Where(x => x.Name.Contains(value) || 
                                                  x.Message.Contains(value) ||
                                                  x.Email.Contains(value) ||
                                                  x.GivenName.Contains(value) ||
                                                  x.Surname.Contains(value)
                                                  );

        return _mapper.Map<IEnumerable<ChatterDto>>(chatterList);
    }

    public Task<ChatterDto> CreateUpdateChatter(ChatterDto chatter)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteChatter(int id)
    {
        throw new NotImplementedException();
    }
}