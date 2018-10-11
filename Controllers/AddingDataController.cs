using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuserORM_MySQL.Controllers
{
    public class AddingDataController : Controller
    {
        CategoryFac cf = new CategoryFac();

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category c)
        {
            int id = 0;

            if (ModelState.IsValid)
            {
                id = cf.Insert(c);
                ViewBag.MSG = "Kategorien er oprettet som række " + id.ToString();
            }
            else
            {
                ViewBag.MSG = "Alle felter skal udfyldes!!!";
            }
            return View();
        }
    }
}