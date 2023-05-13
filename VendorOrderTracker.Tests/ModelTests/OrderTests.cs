using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorOrderTracker.Tests
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
      Order newOrder = new Order("title","bread", 40, 10);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void ClearAll_ClearInstanceOfOrder_()
    {
      Order newOrder = new Order("title","bread", 40, 10);
      List<Order> expected = new List<Order> {};
      Order.ClearAll();
      CollectionAssert.AreEqual(expected, Order.GetAll());
    }

    [TestMethod]
    public void Find_ReturnInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title","bread", 40, 10);
      Order result = Order.Find(1);
      Assert.AreEqual(newOrder, result);
    }

  }
}

