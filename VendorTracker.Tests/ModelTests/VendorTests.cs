using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests 
{
  [TestClass]
  public class VendorTests
  {
    public Vendor vendorOne;
    public string name;
    public string description;
    public string phoneNumber;

    [TestInitialize]
    public void TestInitialize()
    {
      name = "Twisted Croissant";
      description = "We Believe in Quality, Community, and Croissants That Are (Almost) Too Pretty to Eat";
      phoneNumber = "(503) 477-5514";
      vendorOne = new Vendor(name, description, phoneNumber);      
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceofVendor_Vendor()
    {
      Assert.AreEqual(typeof(Vendor), vendorOne.GetType());
    }
  }
}