using System.Collections.Generic;
using SqlDataLayer;

namespace AbstractionForDomain
{
    public interface IFoodMenuItems
    {
        List<FoodMenu> GetMenuItems();
    }
}