using MongoData;
using System.Collections.Generic;

namespace AbstractionForDomain
{
    public interface IFoodMenuDomain
    {
        List<OrderedFoodMenu> GetAll();
        OrderedFoodMenu AddOrder(OrderedFoodMenu order);
    }
}
