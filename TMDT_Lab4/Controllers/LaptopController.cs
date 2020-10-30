using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TMDT_Lab4.Models;

namespace TMDT_Lab4.Controllers
{
    public class LaptopController : Controller
    {
        TMDT5Entities db = new TMDT5Entities();
        // GET: Laptop
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getCompany()
        {
            var ListCompany = db.laptops.GroupBy(l => l.Company).Select(l => l.Key);
            return PartialView(ListCompany);
        }
        public ActionResult getScreenResolution()
        {
            var ListSR = db.laptops.GroupBy(l => l.ScreenResolution).Select(l => l.Key);
            return PartialView(ListSR);
        }
        public ActionResult getTypeName()
        {
            var ListTypeName = db.laptops.GroupBy(l => l.TypeName).Select(l => l.Key);
            return PartialView(ListTypeName);
        }
        public ActionResult getInch()
        {
            var ListInch = db.laptops.GroupBy(l => l.Inches).Select(l => l.Key);
            return PartialView(ListInch);
        }
        public ActionResult getCPU()
        {
            var ListCPU = db.laptops.GroupBy(l => l.Cpu).Select(l => l.Key);
            return PartialView(ListCPU);
        }
        public ActionResult getSpeed()
        {
            var ListSpeed = db.laptops.GroupBy(l => l.Speed).Select(l => l.Key);
            return PartialView(ListSpeed);
        }
        public ActionResult getMemory()
        {
            var ListMemory = db.laptops.GroupBy(l => l.Memory).Select(l => l.Key);
            return PartialView(ListMemory);
        }
        public ActionResult getRam()
        {
            var ListRam = db.laptops.GroupBy(l => l.Ram).Select(l => l.Key);
            return PartialView(ListRam);
        }
        public ActionResult getGPU()
        {
            var ListGPU = db.laptops.GroupBy(l => l.Gpu).Select(l => l.Key);
            return PartialView(ListGPU);
        }
        public ActionResult getOS()
        {
            var ListOS = db.laptops.GroupBy(l => l.OpSys).Select(l => l.Key);
            return PartialView(ListOS);
        }
        public ActionResult getPrice()
        {
            var ListPrice = db.laptops.GroupBy(l => l.Price_euros).Select(l => l.Key);
            return PartialView(ListPrice);
        }
        public ActionResult getWeight()
        {
            var ListWeight = db.laptops.GroupBy(l => l.Weight).Select(l => l.Key);
            return PartialView(ListWeight);
        }
        public ActionResult getSortBy()
        {
            var ListPrice = db.laptops.GroupBy(l => l.Gen).Select(l => l.Key);
            return PartialView(ListPrice);
        }
    }
}