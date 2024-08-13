using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces.IRepositories;

public interface IModel2Repository : IGenericRepository<Model2>
{
    void CustomBehavior2(Model2 obj);
}
