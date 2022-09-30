using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests 
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public Vendor vendorOne;
    public string nameOne;
    public string descriptionOne;
    public string phoneNumberOne;

    public Vendor vendorTwo;
    public string nameTwo;
    public string descriptionTwo;
    public string phoneNumberTwo;

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestInitialize]
    public void TestInitialize()
    {
      nameOne = "Twisted Croissant";
      descriptionOne = "We Believe in Quality, Community, and Croissants That Are (Almost) Too Pretty to Eat";
      phoneNumberOne = "(503) 477-5514";
      vendorOne = new Vendor(nameOne, descriptionOne, phoneNumberOne);      

      nameTwo = "Fleur De Lis Bakery & Cafe";
      descriptionTwo = "Bright French bakeshop known for homemade breads & pastries serving egg dishes, salads & sandwiches.";
      phoneNumberTwo = "(503) 459-4887";
      vendorTwo = new Vendor(nameTwo, descriptionTwo, phoneNumberTwo);      
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceofVendor_Vendor()
    {
      Assert.AreEqual(typeof(Vendor), vendorOne.GetType());
    }

    [TestMethod]
    public void GetName_ReturnName_String()
    {
      string result = vendorOne.Name;
      Assert.AreEqual(nameOne, result);
    }

    [TestMethod]
    public void GetAll_ReturnListOfVendors_List()
    {
      List<Vendor> vendorList = new List<Vendor>{ vendorOne, vendorTwo };
      CollectionAssert.AreEqual(vendorList, Vendor.GetAll());
    }


  }
}