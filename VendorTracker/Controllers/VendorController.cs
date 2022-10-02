using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
  public class VendorController : Controller
    {
      [HttpGet("/vendor")]
      public ActionResult Index()
      {
          List<Vendor> vendors = Vendor.GetAll(); 
          return View(vendors);
      }

      [HttpGet("/vendor/new")]
      public ActionResult New()
      {
          return View();
      }

      [HttpPost("/vendor/")]
      public ActionResult Create(string name, string description, string phoneNumber)
      {
          Vendor newVendor = new Vendor(name, description, phoneNumber);
          return RedirectToAction("Index");
      }

      [HttpGet("vendor/{id}")]
      public ActionResult Show(int id)
      {
          Vendor foundVendor = Vendor.Find(id);
          return View(foundVendor);
      }

      [HttpPost("vendor/{id}")]
      public ActionResult Create(string title, string description, int price, string date, int id)
      {
          Order newOrder = new Order(title, description, price, date);
          Vendor foundVendor = Vendor.Find(id);
          foundVendor.Orders.Add(newOrder);
          return RedirectToAction("Index");
      }
    }
}