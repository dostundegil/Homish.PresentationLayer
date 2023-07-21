using Homish.DataAccessLayer.Abstract;
using Homish.DataAccessLayer.Repository;
using Homish.DataAccessLayer.Settings;
using Homish.EntityLayer;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homish.DataAccessLayer.Concrate
{
    public class EfPropertyDal : GenericRepository<Property>, IPropertyDal
    {
        private readonly IMongoCollection<Property> collection;
        public EfPropertyDal(IMongoSettings mongoSettings) : base(mongoSettings)
        {
            var client = new MongoClient(mongoSettings.ConnectionString);
            var database = client.GetDatabase(mongoSettings.DatabaseName);

            collection = database.GetCollection<Property>(typeof(Property).Name.ToLowerInvariant());
        }

        public List<Property> Take2Property()
        {
            return collection.Find(value=>true).Limit(2).ToList();
        }
    }
}
