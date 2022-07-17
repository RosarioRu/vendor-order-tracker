using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using BakeryTracker.Models;

namespace BakeryTracker.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index() 
    { 
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors); 
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string description)
    {
      Vendor newVendor = new Vendor(vendorName, description);
      // return RedirectToAction("Index", "Home");
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.FindVendor(id);
      List<Order> ordersForThisVendor = selectedVendor.VendorOrders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", ordersForThisVendor);
      return View(model);
    }

    [HttpPost("/vendors/{id}")]
    public ActionResult Show(int id, string titleOfOrder, string description, double price, string date)
    {
      Order newOrder = new Order(titleOfOrder, description, price, date);
      Vendor selectedVendor = Vendor.FindVendor(id);
      List<Order> ordersForThisVendor = selectedVendor.VendorOrders;
      return View(ordersForThisVendor);
    }

    

  }
}