using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      // Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("title","bread", 40, 10);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      Order newOrder1 = new Order("title","bread", 40, 10);
      Order newOrder2 = new Order("title","pastry", 45, 9);
      List<Order> newOrder = new List<Order> { newOrder1, newOrder2 };
      //Act
      List<Order> result = Order.GetAll();
      //Assert
      CollectionAssert.AreEqual(newOrder, result);
    }

    // [TestMethod]
    // public void ClearAll_ClearInstanceOfOrder_()
    // {
    //   Order newOrder = new Order("title","bread", 40, 10);
    //   List<Order> expected = new List<Order> {};
    //   Order.ClearAll();
    //   CollectionAssert.AreEqual(expected, newOrder.ClearAll());
    // }


  }
}

