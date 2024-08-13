using AutoMapper;
using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Domain.Models;

namespace Notion.API.MappingProfiles;

public class Model2Profile : Profile
{
    public Model2Profile()
    {
        CreateMap<Model2, Model2DTO>().ReverseMap();
    }
}
