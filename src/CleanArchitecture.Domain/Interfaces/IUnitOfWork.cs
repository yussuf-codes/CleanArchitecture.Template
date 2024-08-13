using CleanArchitecture.Domain.Interfaces.IRepositories;

namespace CleanArchitecture.Domain.Interfaces;

public interface IUnitOfWork
{
    IModel1Repository Model1Repository { get; }
    IModel2Repository Model2Repository { get; }
    IModel3Repository Model3Repository { get; }
    void SaveChanges();
}
