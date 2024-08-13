using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces.IRepositories;

public interface IModel3Repository : IGenericRepository<Model3>
{
    void CustomBehavior3(Model3 obj);
}
