using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homish.EntityLayer.Abstract;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Homish.EntityLayer
{
    public class Property : IMongoEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int BedroomCount { get; set; }
        public int BathroomCount { get; set; }
        public string Square { get; set; }
        public string Image { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }
    }
}
