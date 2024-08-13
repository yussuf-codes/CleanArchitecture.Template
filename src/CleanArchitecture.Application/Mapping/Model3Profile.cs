using AutoMapper;
using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Domain.Models;

namespace Notion.API.MappingProfiles;

public class Model3Profile : Profile
{
    public Model3Profile()
    {
        CreateMap<Model3, Model3DTO>().ReverseMap();
    }
}
