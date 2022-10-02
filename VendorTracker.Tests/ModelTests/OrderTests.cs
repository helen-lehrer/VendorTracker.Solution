using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public string titleOne;
    public string descriptionOne;
    public int priceOne;
    public string dateOne;
    public Order orderOne;

    public string titleTwo;
    public string descriptionTwo;
    public int priceTwo;
    public string dateTwo;
    public Order orderTwo;
    
    public void Dispose()
    {
      Order.ClearAll(); 
    }

    [TestInitialize]
    public void TestInitialize()
    {
      titleOne = "Croissants";
      descriptionOne = "25 extra flaky croissants & 25 chocolate croissants";
      priceOne = 100;
      dateOne = "9/15/22";
      orderOne = new Order(titleOne, descriptionOne, priceOne, dateOne);

      titleTwo = "Baklava";
      descriptionTwo = "25 pistachio & 25 walnut";
      priceTwo = 50;
      dateTwo = "9/20/22";
      orderTwo = new Order(titleTwo, descriptionTwo, priceTwo, dateTwo);
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Assert.AreEqual(typeof(Order), orderOne.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnOrderTitle_String()
    {
      string result = orderOne.Title;
      Assert.AreEqual(titleOne, result);
    }

    [TestMethod]
    public void GetAll_ReturnList_List()
    {
      List<Order> orderList = new List<Order> { orderOne, orderTwo };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(orderList, result);
    }

    [TestMethod]
    public void Find_ReturnOrderById_Vendor()
    {
      Order result = Order.Find(1);
      Assert.AreEqual(orderOne, result);
    }
  }
}