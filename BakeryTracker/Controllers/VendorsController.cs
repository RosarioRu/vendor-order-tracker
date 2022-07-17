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

    [HttpPost("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

  }
}