using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyBankApp.Models;

namespace MyBankApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
public IActionResult Customers()
{
    // 1. Create a list of fake customers (this is our temporary data)
    var customerList = new List<Customer>
    {
        new Customer { Id = 1, FirstName = "أحمد", LastName = "علي", Email = "ahmad.ali@email.com", CreatedDate = DateTime.Now },
        new Customer { Id = 2, FirstName = "فاطمة", LastName = "محمد", Email = "fatima.mohd@email.com", CreatedDate = DateTime.Now },
        new Customer { Id = 3, FirstName = "خالد", LastName = "حسن", Email = "khaled.hassan@email.com", CreatedDate = DateTime.Now }
    };

    // 2. Send this list to the View
    return View(customerList);
}


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
