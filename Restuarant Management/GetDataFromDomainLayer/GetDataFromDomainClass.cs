using AbstractionForApplicationLayer;
using AbstractionForDomain;
using SqlDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromDomainLayer
{
    public class GetDataFromDomainClass : IGetDataFromDomainClass
    {
        IFoodMenuItems _foodMenuItems;
        public GetDataFromDomainClass(IFoodMenuItems foodMenuItems)
        {
            _foodMenuItems = foodMenuItems;
        }
        //public List<FoodMenuApplication> GetMenuItemsFromDomain()
        //{
           
        //}

        List<FoodMenu> IGetDataFromDomainClass.GetMenuItemsFromDomain()
        {
            return _foodMenuItems.GetMenuItems();
        }
    }
}
