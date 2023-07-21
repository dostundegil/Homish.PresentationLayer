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
    public class AboutUs : IMongoEntity
    {
        public string Title1 { get; set; }
        public string Desciription { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Title2 { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }

    }
}
