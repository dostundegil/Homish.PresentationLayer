using Homish.EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homish.DataAccessLayer.Repository
{
    public interface IGenericRepository<T> where T : IMongoEntity
    {
        List<T> GetAll();
        T GetById(string id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(string id);
    }
}
