using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services.Contracts
{
    public interface IBaseService<T> where T : BaseModel
    {

        Task<IEnumerable<T>> GetAsync();

        Task<T> GetById(Guid id);

        void AddOrUpdate(T entry);

        void Remove(Guid id);
    }
}
