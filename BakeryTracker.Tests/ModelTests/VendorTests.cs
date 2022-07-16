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
    }

    [TestMethod]
    public void RetrieveName_ReturnVendorName_string()
    {
      //Arrange
      string name = "John's Pancake House";
      Vendor newVendor = new Vendor(name, "a description here.");
      //Act
      string result = newVendor.Name;
      //Assert
      Assert.AreEqual(name, result);
    }

  }
} 