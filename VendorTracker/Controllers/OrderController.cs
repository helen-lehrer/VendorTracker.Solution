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
    }
}