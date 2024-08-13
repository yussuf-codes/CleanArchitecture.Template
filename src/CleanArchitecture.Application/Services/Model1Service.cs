using System.Collections.Generic;
using AutoMapper;
using CleanArchitecture.Application.DTOs;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Interfaces.IRepositories;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.Services;

public class Model1Service : IGenericService<Model1DTO>
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;

    public Model1Service(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public Model1DTO Add(Model1DTO obj)
    {
        return _mapper.Map<Model1DTO>(_unitOfWork.Model1Repository.Add(_mapper.Map<Model1>(obj)));
    }

    public void Delete(int id)
    {
        if (_unitOfWork.Model1Repository.Exists(id))
            _unitOfWork.Model1Repository.Delete(id);
        else
            throw new NotFoundException();
    }

    public IEnumerable<Model1DTO> Get()
    {
        return _mapper.Map<List<Model1DTO>>(_unitOfWork.Model1Repository.Get());
    }

    public Model1DTO Get(int id)
    {
        if (_unitOfWork.Model1Repository.Exists(id))
            return _mapper.Map<Model1DTO>(_unitOfWork.Model1Repository.Get(id));
        else
            throw new NotFoundException();
    }

    public void Update(int id, Model1DTO obj)
    {
        if (id != obj.Id)
            throw new BadRequestException();
        if (!_unitOfWork.Model1Repository.Exists(id))
            throw new NotFoundException();
        _unitOfWork.Model1Repository.Update(id, _mapper.Map<Model1>(obj));
    }
}
