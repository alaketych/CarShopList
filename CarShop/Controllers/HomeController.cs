using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarShop.Controllers
{
    public class HomeController : Controller
    {
        private Models.ShopDBModel db = new Models.ShopDBModel();

        public ActionResult Index() {
            var Items = db.Cars;

            return View(Items);
        }

        public ActionResult CarPage(int item_id) {
            var Item = db.Cars.FirstOrDefault(x => x.Id == item_id);

            if (Item == null) {
                return Content("<h1>Page not found</h1>");
            }

            return View(Item);
        }

        [ChildActionOnly]
        public ActionResult Nav() {
            var Items = db.Cars;
            string result = "";
            foreach (var item in Items) {
                result += "<li><a href ='/Home/CarPage/?item_id=" + item.Id + "' title='" + item.Title + "'>" + item.Title + "</a></li>";
            }
            return Content(result);
        }
    }
}