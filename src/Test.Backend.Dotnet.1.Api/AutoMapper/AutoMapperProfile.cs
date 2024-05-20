using Test.Backend.Dotnet.1.Api.Models;
using Test.Backend.Dotnet.1.Core.Entities;

using AutoMapper;

namespace Test.Backend.Dotnet.1.Api.AutoMapper;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ItemRequest, Item>();
    }
}
