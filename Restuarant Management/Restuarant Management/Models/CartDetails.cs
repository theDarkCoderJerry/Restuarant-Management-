using AbstractionForApplicationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restuarant_Management.Models
{
    public class CartDetails : ICartDetail
    {
        public string FoodItem { get; set; }
        public int Price { get; set; }
    }
}