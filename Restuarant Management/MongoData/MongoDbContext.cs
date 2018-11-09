using MongoData.Properties;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoData
{
    public class MongoDbContext
    {
        IMongoDatabase database;
        public MongoDbContext()
        {
            var connectionstring = Settings.Default.ConnectionString;
            var setting = MongoClientSettings.FromUrl(new MongoUrl(connectionstring));
            var client = new MongoClient(setting);
            database = client.GetDatabase(Settings.Default.Database);
        }
        public IMongoCollection<OrderedFoodMenu> OrderedFoodData => database.GetCollection<OrderedFoodMenu>("OrderedData");
    }
}
