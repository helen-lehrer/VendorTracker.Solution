using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    public string titleOne;
    public string descriptionOne;
    public int priceOne;
    public string dateOne;
    public Order orderOne;

    [TestInitialize]
    public void TestInitialize()
    {
      titleOne = "Croissants";
      descriptionOne = "25 extra flaky croissants & 25 chocolate croissants";
      priceOne = 100;
      dateOne = "9/15/22";
      orderOne = new Order(titleOne, descriptionOne, priceOne, dateOne);
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Assert.AreEqual(typeof(Order), orderOne.GetType());
    }
  }
}