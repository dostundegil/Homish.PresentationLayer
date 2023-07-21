using Homish.DataAccessLayer.Abstract;
using Homish.DataAccessLayer.Repository;
using Homish.DataAccessLayer.Settings;
using Homish.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homish.DataAccessLayer.Concrate
{
    public class EfStatisticsDal : GenericRepository<Statistics>, IStatisticsDal
    {
        public EfStatisticsDal(IMongoSettings mongoSettings) : base(mongoSettings)
        {
        }
    }
}
