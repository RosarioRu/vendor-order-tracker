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
      return View(); 
    }

  }
}