using AutoMapper;
using Domain.Entities;
using Presentation.Dtos;

namespace Application.Mapper;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<AccountGroupDto, AccountGroup>().ReverseMap();
        CreateMap<AccountDto, Account>().ReverseMap();
    }
}