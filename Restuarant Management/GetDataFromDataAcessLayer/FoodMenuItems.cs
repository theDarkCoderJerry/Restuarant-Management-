using AbstractionForDomain;
using SqlDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromDataAcessLayer
{
    public class FoodMenuItems : IFoodMenuItems
    {
        MenuListEntities db = new MenuListEntities();
        public List<FoodMenu> GetMenuItems()
        {
           return db.FoodMenus.ToList();
        }
    }
}
