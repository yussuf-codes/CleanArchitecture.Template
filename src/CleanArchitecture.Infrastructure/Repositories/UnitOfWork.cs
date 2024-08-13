using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Interfaces.IRepositories;
using CleanArchitecture.Infrastructure.Persistence;

namespace CleanArchitecture.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public IModel1Repository Model1Repository { get; private set; }
    public IModel2Repository Model2Repository { get; private set; }
    public IModel3Repository Model3Repository { get; private set; }

    private readonly ApplicationDbContext _databaseContext;

    public UnitOfWork
    (
        ApplicationDbContext databaseContext,
        Model1Repository model1,
        Model2Repository model2,
        Model3Repository model3
    )
    {
        _databaseContext = databaseContext;

        Model1Repository = model1;
        Model2Repository = model2;
        Model3Repository = model3;
    }

    public void SaveChanges()
    {
        _databaseContext.SaveChanges();
    }
}
