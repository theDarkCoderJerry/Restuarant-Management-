using AbstractionForDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoData;
using MongoDB.Driver;

namespace GetDataFromDataAcessLayer
{
    public class FoodMenuDomain : IFoodMenuDomain
    {
        private MongoDbContext db = new MongoDbContext();

        public OrderedFoodMenu AddOrder(OrderedFoodMenu order)
        {
            db.OrderedFoodData.InsertOne(order);
            return order;
        }

        public List<OrderedFoodMenu> GetAll()
        {
            return db.OrderedFoodData.AsQueryable().ToList();
        }
    }
}
