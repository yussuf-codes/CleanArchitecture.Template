using CleanArchitecture.Domain.Interfaces.IRepositories;
using CleanArchitecture.Domain.Models.Abstractions;
using CleanArchitecture.Infrastructure.Persistence;

namespace CleanArchitecture.Infrastructure.Repositories.Abstractions;

public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseModel
{
    protected readonly ApplicationDbContext _databaseContext;

    public GenericRepository(ApplicationDbContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public virtual T Add(T obj)
    {
        throw new NotImplementedException();
    }

    public virtual void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public virtual bool Exists(int id)
    {
        throw new NotImplementedException();
    }

    public virtual IEnumerable<T> Get()
    {
        throw new NotImplementedException();
    }

    public virtual T Get(int id)
    {
        throw new NotImplementedException();
    }

    public virtual void Update(int id, T obj)
    {
        throw new NotImplementedException();
    }
}
