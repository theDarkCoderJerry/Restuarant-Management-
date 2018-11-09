using AbstractionForApplicationLayer;
using AbstractionForDomain;
using Restuarant_Management.Models;
using SqlDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Forms;

namespace Restuarant_Management.Controllers
{
   
    public class HomeController : Controller
    {
        CartDetails _cartDetails = new CartDetails();
        MenuListEntities db = new MenuListEntities();
        IGetDataFromDomainClass _foodMenuItems;
       // DataGridView.DataSource = BindingSource
        public HomeController(IGetDataFromDomainClass foodMenuItems)
        {
            _foodMenuItems = foodMenuItems;
        }

      
        public ActionResult GetMenuData()
        {
            return View(_foodMenuItems.GetMenuItemsFromDomain().ToList());
        }

        public ActionResult AddToCart(int id)
        {
            FoodMenu _foodmenu = db.FoodMenus.Find(id);
            Response.Cookies["FoodItem"].Value = _foodmenu.FoodItem;
            Response.Cookies["Price"].Value = _foodmenu.Price.ToString();

            return RedirectToAction("GetMenuData");
        }

        public ActionResult ViewCart()
        {
           
            _cartDetails.FoodItem = Request.Cookies["FoodItem"].Value;
            _cartDetails.Price = Convert.ToInt32(Request.Cookies["Price"].Value);
            return View(_cartDetails);
        }


    }
}