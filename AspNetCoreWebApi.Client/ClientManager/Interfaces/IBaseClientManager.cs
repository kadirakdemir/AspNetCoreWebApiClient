using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebApi.Client.ClientManager.Interfaces
{
    public interface IBaseClientManager<TEntity> where TEntity:class
    {
        ICollection<TEntity> GetAll();
        Task<ICollection<TEntity>> GetAllAsync();
        TEntity GetById(int id);
        Task<TEntity> GetByIdAsync(int id);
        void Url(string baseUrl, string url);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}
