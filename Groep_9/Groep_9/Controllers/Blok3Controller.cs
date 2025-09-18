using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Groep_9.Controllers
{
    public class Blok3Controller : Controller
    {
        public IActionResult Opdracht1()
        {

        string test = "Hoi";
            return View("Opdracht1", test);

            //code van opdracht 1 hier

        }

        public IActionResult Opdracht2()
        {
            return View();

            //code van opdracht 2 hier
        }
    }
}
