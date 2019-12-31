using HMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HMS.Areas.Dashboard.Controllers
{
    public class AccomodationTypesController : Controller
    {
        AccomodationTypesService accomodationTypesService = new AccomodationTypesService();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listing()
        {
            //var accomodationTypes = 
            return PartialView("_Listing");
        }
    }
}