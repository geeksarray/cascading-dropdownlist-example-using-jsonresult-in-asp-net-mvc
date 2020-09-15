using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCascadingDropDownList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DisplayCategories()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Select Category", Value = "0", Selected = true });

            items.Add(new SelectListItem { Text = "Beverages", Value = "1" });

            items.Add(new SelectListItem { Text = "Condiments", Value = "2" });

            items.Add(new SelectListItem { Text = "Confections", Value = "3" });

            items.Add(new SelectListItem { Text = "Dairy Products", Value = "4" });

            items.Add(new SelectListItem { Text = "Grains/Cereals", Value = "5" });

            items.Add(new SelectListItem { Text = "Meat/Poultry", Value = "6" });

            items.Add(new SelectListItem { Text = "Produce", Value = "7" });

            items.Add(new SelectListItem { Text = "Seafood", Value = "8" });

            ViewBag.CategoryType = items;

            return View();
        }

        public JsonResult GetSubCategories(string id)
        {
            List<SelectListItem> subCat= new List<SelectListItem>();

            subCat.Add(new SelectListItem { Text = "Select", Value = "0" });

            switch (id)
            {
                case "1":
                    subCat.Add(new SelectListItem { Text = "Coffee", Value = "1" });
                    subCat.Add(new SelectListItem { Text = "Energy Drinks", Value = "2" });
                    subCat.Add(new SelectListItem { Text = "Tea", Value = "3" });
                    subCat.Add(new SelectListItem { Text = "Cold drinks", Value = "4" });
                    break;
                case "2":
                    subCat.Add(new SelectListItem { Text = "Garlic", Value = "1" });
                    subCat.Add(new SelectListItem { Text = "Pickles", Value = "2" });
                    subCat.Add(new SelectListItem { Text = "Raita", Value = "3" });
                    subCat.Add(new SelectListItem { Text = "Sauce", Value = "4" });
                    break;
                case "3":
                    subCat.Add(new SelectListItem { Text = "Desserts", Value = "1" });
                    subCat.Add(new SelectListItem { Text = "Sweet Breads", Value = "2" });                    
                    break;
                case "4":
                    subCat.Add(new SelectListItem { Text = "Cheese", Value = "1" });                    
                    break;
                case "5":
                    subCat.Add(new SelectListItem { Text = "Crackers", Value = "1" });
                    subCat.Add(new SelectListItem { Text = "Pasta", Value = "2" });
                    break;
                case "6":
                    subCat.Add(new SelectListItem { Text = "Prepared meats", Value = "1" });                    
                    break;
                case "7":
                    subCat.Add(new SelectListItem { Text = "Dried Fruit", Value = "1" });                    
                    break;
                case "8":
                    subCat.Add(new SelectListItem { Text = "Fish", Value = "1" });
                    subCat.Add(new SelectListItem { Text = "Crab", Value = "2" });
                    break;
                default:
                    subCat.Add(new SelectListItem { Text = "Coffee", Value = "1" });
                    subCat.Add(new SelectListItem { Text = "Energy Drinks", Value = "2" });
                    subCat.Add(new SelectListItem { Text = "Tea", Value = "3" });
                    subCat.Add(new SelectListItem { Text = "Cold drinks", Value = "4" });
                    break;
            }

            return Json(new SelectList(subCat, "Value", "Text"));
        }
    }
}