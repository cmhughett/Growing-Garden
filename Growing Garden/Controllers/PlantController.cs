using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Growing_Garden.Models;

namespace Growing_Garden.Controllers
{
    public class PlantController : Controller
    {
        public ActionResult Details()
        {
            Plant plant = new Plant()
            {
                CommonName = "Hyacinth",
                SciName = "Hycinthus Orientalis",
                BedLocation = "North East",
                PlantTime = "Fall (bulbs)",
                BloomTime = "Spring - Summer",

            };

            return View(plant);
        }
    }
}