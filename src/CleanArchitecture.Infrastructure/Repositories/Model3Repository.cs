using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Interfaces.IRepositories;
using CleanArchitecture.Infrastructure.Persistence;
using CleanArchitecture.Infrastructure.Repositories.Abstractions;

namespace CleanArchitecture.Infrastructure.Repositories;

public class Model3Repository : GenericRepository<Model3>, IModel3Repository
{
    public Model3Repository(ApplicationDbContext databaseContext) : base(databaseContext)
    {

    }

    public override Model3 Add(Model3 obj)
    {
        // Doing some custom behavior
        // _databaseContext.Entities3.Add(obj);
        throw new NotImplementedException();
        // Doing some custom behavior
    }

    public void CustomBehavior3(Model3 obj)
    {
        throw new NotImplementedException();
    }
}
