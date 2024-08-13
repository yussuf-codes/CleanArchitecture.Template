using AutoMapper;
using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Domain.Models;

namespace Notion.API.MappingProfiles;

public class Model1Profile : Profile
{
    public Model1Profile()
    {
        CreateMap<Model1, Model1DTO>().ReverseMap();
    }
}
