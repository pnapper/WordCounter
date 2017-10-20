using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      [HttpPost("/result")]
      public ActionResult Result()
      {
        CountWords newWord = new CountWords(Request.Form["new-word"], Request.Form["new-sentence"]);
        return View(newWord);
      }
  }
}
