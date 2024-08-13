using System.Collections.Generic;

namespace CleanArchitecture.Domain.Interfaces.IRepositories;

public interface IGenericService<T>
{
    T Add(T obj);
    void Delete(int id);
    IEnumerable<T> Get();
    T Get(int id);
    void Update(int id, T obj);
}
