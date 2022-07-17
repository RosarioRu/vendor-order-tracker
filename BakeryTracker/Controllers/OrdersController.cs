using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using BakeryTracker.Models;

namespace BakeryTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}