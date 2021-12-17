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
      Order.ClearAll();
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

    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_String()
    {
      string title = "Test Title";
      string description = "Test description";
      double price = 0.00;
      string date = "2021-12-17";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(date, newOrder.Date);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      CollectionAssert.AreEqual(newList, Order.GetAll());
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_VendorList()
    {
      string title01 = "Test Title 1";
      string description01 = "Test description 1";
      double price01 = 1.00;
      string date01 = "2021-12-17";

      string title02 = "Test Title 2";
      string description02 = "Test description 2";
      double price02 = 2.00;
      string date02 = "2021-12-18";

      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      CollectionAssert.AreEqual(newList, Order.GetAll());
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string title01 = "Test Title 1";
      string description01 = "Test description 1";
      double price01 = 1.00;
      string date01 = "2021-12-17";

      string title02 = "Test Title 2";
      string description02 = "Test description 2";
      double price02 = 2.00;
      string date02 = "2021-12-18";

      Order newOrder1 = new Order(title01, description01, price01, date01);
      Order newOrder2 = new Order(title02, description02, price02, date02);
      Assert.AreEqual(newOrder2, Order.Find(2));
    }
  }
}