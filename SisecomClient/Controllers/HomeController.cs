using Microsoft.AspNetCore.Mvc;
using SisecomClient.Models.ViewModel;
using System.Diagnostics;
using SisecomClient.Models;

namespace SisecomClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ClientModel client = new ClientModel();

            client.Id = 1;
            client.Nome = "Victor Hugo";

            return View(client);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
