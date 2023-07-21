using Homish.DataAccessLayer.Repository;
using Homish.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homish.DataAccessLayer.Abstract
{
    public interface IPropertyDal:IGenericRepository<Property>
    {
        public List<Property> Take2Property();
    }
}
