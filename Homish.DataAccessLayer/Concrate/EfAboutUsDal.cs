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
    public class EfAboutUsDal : GenericRepository<AboutUs>, IAboutUsDal
    {
        public EfAboutUsDal(IMongoSettings mongoSettings) : base(mongoSettings)
        {
        }
    }
}
