using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homish.DataAccessLayer.Settings
{
    public class MongoSettings : IMongoSettings
    {
        public string AboutUsCollectionName { get; set; }
        public string PropertiesByAreaCollectionName { get; set; }
        public string PropertyCollectionName { get; set; }
        public string StatisticsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
