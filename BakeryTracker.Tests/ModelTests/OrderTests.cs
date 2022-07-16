using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {

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

  }
}