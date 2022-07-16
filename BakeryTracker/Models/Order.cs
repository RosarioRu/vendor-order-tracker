using System;
using System.Collections.Generic; 


namespace BakeryTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set;}
    public string Date { get; set;}
    public int OrderId { get; }
    private static List<Order> _instancesOfOrders = new List<Order> {};

    public Order(string titleOfOrder, string orderDescription, double price, string dateOfOrder)
    {
      Title = titleOfOrder;
      Description = orderDescription;
      Price = price;
      Date = dateOfOrder;
      _instancesOfOrders.Add(this);
      OrderId = _instancesOfOrders.Count;
    }

    //method to clear the list of orders called _instancesOfOrders
    public static void EmptyOrderList()
    {
      _instancesOfOrders.Clear();
    }


//class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
  }
} 