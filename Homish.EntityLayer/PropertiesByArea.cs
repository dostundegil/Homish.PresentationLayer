using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homish.EntityLayer.Abstract;

namespace Homish.EntityLayer
{
    public class PropertiesByArea : IMongoEntity
    {
        public string City { get; set; }
        public string SmallDescription { get; set; }
        public string ImageUrl { get; set; }
        public int Amount { get; set; }
    }
}
