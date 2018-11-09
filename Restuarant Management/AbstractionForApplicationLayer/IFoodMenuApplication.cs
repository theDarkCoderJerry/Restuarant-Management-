using MongoData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionForApplicationLayer
{
    public interface IFoodMenuApplication
    {
        List<OrderedFoodMenu> GetAll();

        OrderedFoodMenu AddOrder(ICartDetail cart,string EmailId);
    }
}
