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

  }
}