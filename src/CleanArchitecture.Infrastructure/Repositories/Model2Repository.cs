using CleanArchitecture.Domain.Models;
using CleanArchitecture.Domain.Interfaces.IRepositories;
using CleanArchitecture.Infrastructure.Persistence;
using CleanArchitecture.Infrastructure.Repositories.Abstractions;

namespace CleanArchitecture.Infrastructure.Repositories;

public class Model2Repository : GenericRepository<Model2>, IModel2Repository
{
    public Model2Repository(ApplicationDbContext databaseContext) : base(databaseContext)
    {

    }

    public override Model2 Add(Model2 obj)
    {
        // Doing some custom behavior
        // _databaseContext.Entities2.Add(obj);
        throw new NotImplementedException();
        // Doing some custom behavior
    }

    public void CustomBehavior2(Model2 obj)
    {
        throw new NotImplementedException();
    }
}
