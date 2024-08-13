using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Interfaces.IRepositories;
using CleanArchitecture.Infrastructure.Persistence;
using CleanArchitecture.Infrastructure.Repositories.Abstractions;

namespace CleanArchitecture.Infrastructure.Repositories;

public class Model1Repository : GenericRepository<Model1>, IModel1Repository
{
    public Model1Repository(ApplicationDbContext databaseContext) : base(databaseContext)
    {

    }

    public override Model1 Add(Model1 obj)
    {
        // Doing some custom behavior
        // _databaseContext.Entities1.Add(obj);
        throw new NotImplementedException();
        // Doing some custom behavior
    }

    public void CustomBehavior1(Model1 obj)
    {
        throw new NotImplementedException();
    }
}
