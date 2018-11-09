using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoData
{
  public  class OrderedFoodMenu
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string FoodItem { get; set; }
        public int Price { get; set; }
        public string EmailId { get; set; }
    }
}
