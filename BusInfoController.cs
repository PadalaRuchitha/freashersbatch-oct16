using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_2.Models;

namespace Assignment_2.Controllers
{
    public class BusInfoController : Controller
    {
        // GET: BusInfo
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult create(BusInfo busdetails)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    BusInfoDB busInfoDB = new BusInfoDB();
                    if (busInfoDB.Insertbusinfo(busdetails))
                    {
                        ViewBag.Message = "Bus Details Added Successfully";
                        ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
        public ActionResult BusDetails()
        {
            BusInfoDB busInfo = new BusInfoDB();
            ModelState.Clear();
            return View(busInfo.businfos());
        }
        public ActionResult BusDetailsbyAmount()
        {
            BusInfoDB busInfo = new BusInfoDB();
            ModelState.Clear();
            return View(busInfo.businfosbyamount());
        }
        public ActionResult BusDetailsbyRating()
        {
            BusInfoDB busInfo = new BusInfoDB();
            ModelState.Clear();
            return View(busInfo.businfosbyrating());
        }
        public ActionResult BusDetailsbydate()
        {
            BusInfoDB busInfo = new BusInfoDB();
            ModelState.Clear();
            return View(busInfo.businfosbydate());
        }
        public ActionResult BusDetailsbyboardingpoint()
        {
            BusInfoDB busInfo = new BusInfoDB();
            ModelState.Clear();
            return View(busInfo.businfosbyboardingpoint());
        }
    }
}