using ChatterServiceApi.Models.Dto;
using ChatterServiceApi.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChatterServiceApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ChatterServiceController : ControllerBase
{ 
    private readonly IChatterService _chatterService;
    protected ResponseDto _response;
    
    public ChatterServiceController(IChatterService chatterService)
    {
        _chatterService = chatterService;
        _response = new ResponseDto();
    }
    
    [HttpGet]
    public async Task<object> GetChatter(string? search, int? chatterId)
    {
        _response = new ResponseDto();
        try
        {
            var chatters = await _chatterService.GetAll(search, chatterId);
            _response.Result = chatters;
        }
        catch (Exception e)
        {
            _response.IsSuccessful = false;
            _response.ErrorMessage = new List<string> {e.Message};
        }

        return _response;
    }
}