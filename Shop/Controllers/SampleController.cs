using Microsoft.AspNetCore.Mvc;
using Shop.Models;

namespace Shop.Controllers;

public class SampleController : Controller
{
    public IActionResult GetMessage()
    {
        return PartialView("_GetMessage");
    }
    public IActionResult Index()
    {
        ViewData["Message"] = "Я Сообщение";
        ViewData["Text"] = "Я не я и лошадь не моя";
        ViewBag.Message = "Hello ASP.NET Core";
        string myView = "Test";
        MyTest obj = new MyTest();
        obj.Id = 1;
        obj.Name = "MyName";
        
        //var obj = new { id = 1 };
        //return View("~/Views/Sample/Index.cshtml");
        //return View(obj);
        //return View(myView, obj);
        return View(obj);
    }
    public IActionResult About()
    {
        return View();
    }
}


