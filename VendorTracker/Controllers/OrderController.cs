using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/vendor/{id}/order/new")]
        public ActionResult New(int id)
        {
            Vendor foundVendor = Vendor.Find(id);
            return View(foundVendor);
        }

        [HttpGet("/vendor/{id}/order/{id2}")]
        public ActionResult Show(int id, int id2)
        {
            Order foundOrder = Order.Find(id2); 
            return View(foundOrder);
        }
    }
}