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

  }
}