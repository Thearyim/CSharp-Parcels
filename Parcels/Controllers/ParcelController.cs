using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;
using System;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(string description, int length, int width, int weight, int height)
    {
      Parcel myParcel = new Parcel(description, length, width, weight, height);
      return View("Index", myParcel);
    }

  }
}
