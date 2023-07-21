using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homish.EntityLayer.Abstract;

namespace Homish.EntityLayer
{
    public class Statistics:IMongoEntity
    {
        public int CustomProducts { get; set; }
        public int OurFarms { get; set; }
        public int HappCustomers { get; set; }
    }
}
