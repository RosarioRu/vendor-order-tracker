using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryTracker.Models;
using System.Collections.Generic;
using System;

namespace BakeryTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.EmptyVendorList();
    }
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

    [TestMethod]
    public void RetrieveDescription_ReturnVendorDescription_string()
    {
      //Arrange
      string vendorDescription = "A restaurant that serves pancakes and other breakfast fare.";
      Vendor newVendor = new Vendor("John's Pancakes", vendorDescription);
      //Act
      string result = newVendor.Description;
      //Assert
      Assert.AreEqual(vendorDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnAllInstancesOfVendors_ListOfVendors()
    {
      //Arrange
      string firstName = "Natural Foods";
      string secondName = "Coffee World";
      string firstDescription = "Grocery store we usually make baguettes for.";
      string secondDescription = "Coffee shop in SE we typically make cookies for.";
      Vendor firstVendor = new Vendor(firstName, firstDescription);
      Vendor secondVendor = new Vendor(secondName, secondDescription);
      List<Vendor> listWeAddVendorsToManually = new List<Vendor> {firstVendor, secondVendor};
      //Act
      List<Vendor> listGetAllMethodMakes = Vendor.GetAll(); //I'll need to add GetAll() method in Vendor.cs file for this to work!
      //Assert
      CollectionAssert.AreEqual(listWeAddVendorsToManually, listGetAllMethodMakes);
    }

    [TestMethod]
    public void FindVendorByUniqueID_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      Vendor vendorOne = new Vendor("Natural Foods", "Grocery store in SE PDX");
      Vendor vendorTwo = new Vendor("Coffee Coffee!", "Coffee shop downtown.");
      //Act
      Vendor foundVendor = Vendor.FindVendor(1);
      //Assert
      Assert.AreEqual(vendorOne, foundVendor);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToCorrespondingVendor_ListOfOrders()
    {
      //Arrange
      Order newOrder = new Order("new order title", "new order description", 100, "03/24/2022");
      List<Order> manuallyMadeList = new List<Order> {newOrder};
      Vendor newVendor = new Vendor("Lulu Tea and Treats", "Tea shop in downtown Seattle.");
      //Act
      newVendor.AddOrder(newOrder);
      //Assert
      CollectionAssert.AreEqual(manuallyMadeList, newVendor.VendorOrders);
    }

  }
} 