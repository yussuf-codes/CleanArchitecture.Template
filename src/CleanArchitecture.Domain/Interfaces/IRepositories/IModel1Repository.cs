using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces.IRepositories;

public interface IModel1Repository : IGenericRepository<Model1>
{
    void CustomBehavior1(Model1 obj);
}
