using Homish.DataAccessLayer.Settings;
using Homish.EntityLayer.Abstract;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homish.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : IMongoEntity
    {
        private readonly IMongoCollection<T> collection;

        public GenericRepository(IMongoSettings mongoSettings)
        {
            var client = new MongoClient(mongoSettings.ConnectionString);
            var database = client.GetDatabase(mongoSettings.DatabaseName);

            collection = database.GetCollection<T>(typeof(T).Name.ToLowerInvariant());
        }

        public void Delete(string id)
        {
            collection.FindOneAndDelete(x => x.Id == id);
        }

        public List<T> GetAll()
        {
            return collection.AsQueryable().ToList();
        }

        public T GetById(string id)
        {
            return collection.Find(x => x.Id == id).FirstOrDefault();
        }

        public void Insert(T entity)
        {
            collection.InsertOne(entity);
        }

        public void Update(T entity)
        {
            collection.FindOneAndReplace(x => x.Id == entity.Id, entity);
        }
    }
}
