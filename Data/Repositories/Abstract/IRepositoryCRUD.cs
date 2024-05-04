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
        // which collection should I do as repo collection?
        List<T> GetAll();
        void Create(T item);
        T Get(int id);
        void Update(T old, T @new);
        void Delete(int id);


        
    }
}
