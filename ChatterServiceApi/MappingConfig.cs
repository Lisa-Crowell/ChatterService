using AutoMapper;
using ChatterServiceApi.Models.Dto;

namespace ChatterServiceApi;

public class MappingConfig
{
    public static MapperConfiguration RegisterMaps()
    {
        var mappingConfig = new MapperConfiguration(config =>
        {
            
        });

    return mappingConfig;
    
    }
}