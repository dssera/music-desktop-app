using Data.Entities;
using Data.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Abstract
{
    public interface IRepositoryCRUD<T> where T : BaseEntity
    {
        List<T>? GetCollection(int limit, int offset);
        bool Add(T item);
        T? GetById(int id);
        bool Update(T item);
        bool Delete(int id);
    }

    public interface IRepositoryAssoc<T> where T : BaseEntity
    {
    
    }
}
