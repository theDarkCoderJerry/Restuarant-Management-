using System.Collections.Generic;
using SqlDataLayer;

namespace AbstractionForApplicationLayer
{
    public interface IGetDataFromDomainClass
    {
        List<FoodMenu> GetMenuItemsFromDomain();
    }
}