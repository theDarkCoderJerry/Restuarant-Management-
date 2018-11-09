using AbstractionForApplicationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoData;
using AbstractionForDomain;

namespace GetDataFromDomainLayer
{
    public class FoodMenuApplication : IFoodMenuApplication
    {
        private IFoodMenuDomain _foodMenuDomain;
        public FoodMenuApplication(IFoodMenuDomain foodMenuDomain)
        {
            _foodMenuDomain = foodMenuDomain;
        }

        public OrderedFoodMenu AddOrder(ICartDetail cart,string EmailID )
        {
            var order = new OrderedFoodMenu
            {
                EmailId = EmailID,
                FoodItem = cart.FoodItem,
                Price = cart.Price
            };

            return _foodMenuDomain.AddOrder(order);
        }

        public List<OrderedFoodMenu> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
