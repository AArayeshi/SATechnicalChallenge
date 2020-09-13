using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SATechnicalChallenge.Domain.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> SelectAll();
        Task<T> Insert(T obj);       
        Task<T> Select(int Id);
        Task<T> Update(T obj);
        Task<T> Delete(int Id);
    }
}
