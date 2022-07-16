using System.Collections.Generic; 
using System;

namespace BakeryTracker.Models
{
  public class Vendor
  {

    public string Name { get; set; }
    public string Description { get; set; }
    public int VendorId { get; }
    public List<Order> VendorOrders { get; set; }
    private static List<Vendor> _instancesOfVendors = new List<Vendor> {};

    public Vendor(string nameOfVendor, string descriptionOfVendor)
    {
      Name = nameOfVendor;
      Description = descriptionOfVendor;
      _instancesOfVendors.Add(this);
      VendorId = _instancesOfVendors.Count;
      VendorOrders = new List<Order>{};
    } 

    public static List<Vendor> GetAll()
    {
      return _instancesOfVendors;
    }

    public static void EmptyVendorList()
    {
      _instancesOfVendors.Clear();
    }

    public static Vendor FindVendor(int vendorId)
    {
      return _instancesOfVendors[vendorId-1];
    }

    public void AddOrder(Order orderToAdd)
    {
      VendorOrders.Add(orderToAdd);
    }

  }
} 