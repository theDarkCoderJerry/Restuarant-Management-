using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionForApplicationLayer
{
    public interface ICartDetail
    {
        string FoodItem { get; set; }
        int Price { get; set; }
    }
}
