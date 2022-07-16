using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class VendorTests
  // public class VendorTests : IDisposable
  {

    //some method to clear lists/teardown so tests don't affect each other

    //tests for Vendor class go here
    [TestMethod]
    public void VendorConstructor_CreateAnInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Rosie's Cafe", "Coffee shop downtown, typically requests muffins.");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
      Assert.AreEqual("Rosie's Cafe", newVendor.Name);     
    }

  }
} 