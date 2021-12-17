using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Test Title", "Test description", 0.00, "YYYY-MM-DD");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string title = "Test Title";
      string description = "Test description";
      double price = 0.00;
      string date = "2021-12-17";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(title, newOrder.Title);
    }

    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string title = "Test Title";
      string description = "Test description";
      double price = 0.00;
      string date = "2021-12-17";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(description, newOrder.Description);
    }

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Double()
    {
      string title = "Test Title";
      string description = "Test description";
      double price = 0.00;
      string date = "2021-12-17";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(price, newOrder.Price);
    }
  }
}