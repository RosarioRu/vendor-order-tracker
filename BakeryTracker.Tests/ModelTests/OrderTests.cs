using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.EmptyOrderList();
    }

    //some method to clear lists/teardown so tests don't affect each other

    [TestMethod]
    public void OrderConstructor_CreateAnInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Weekly order", "Weekly order of baguettes for Sam's Cafe.", 45.50, "12/17/2021");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void RetrieveTitle_ReturnOrderTitle_String()
    {
      string orderTitle = "Wedding Order";
      Order newOrder = new Order(orderTitle, "Cake and cupcake order for the Hawkin's wedding", 112.25, "12/12/2021");
      Assert.AreEqual(orderTitle, newOrder.Title);
    }

    [TestMethod]
    public void RetrieveDescription_ReturnOrderDescription_String()
    {
      string orderDescription = "Cake and cupcake order for the Hawkin's wedding";
      Order newOrder = new Order("Wedding Order", orderDescription, 112.25, "12/12/2021");
      Assert.AreEqual(orderDescription, newOrder.Description);
    }

    [TestMethod]
    public void RetrievePrice_ReturnOrderPrice_double()
    {
      double orderPrice = 112.25;
      Order newOrder = new Order("Wedding Order", "Cake and cupcake order for the Hawkin's wedding", orderPrice, "12/12/2021");
      Assert.AreEqual(orderPrice, newOrder.Price);
    }

    [TestMethod]
    public void RetrieveDate_ReturnOrderDate_string()
    {
      string orderDate = "12/12/2020";
      Order newOrder = new Order("Wedding Order", "Cake and cupcake order for the Hawkin's wedding", 100.25, orderDate);
      Assert.AreEqual(orderDate, newOrder.Date);
    }

    [TestMethod]
    public void RetrieveId_ReturnOrderId_int()
    {
      //Arrange
      Order newOrder = new Order("Birthday Order", "Pie order for Wilson Family bday party", 44.50, "10/01/2021");
      //Act
      int orderId = newOrder.OrderId;
      //Assert
      Assert.AreEqual(1, orderId);
    }




  }
}