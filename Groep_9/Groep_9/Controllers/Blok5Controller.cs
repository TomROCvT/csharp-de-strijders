using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Groep_9.Controllers
{
    public class Blok5Controller : Controller
    {

        public IActionResult Opdracht1()
        {
            return View();
        }

        public IActionResult Opdracht6()
        {

            Random rnd = new Random();
            int[] worpen = new int[5];
            int totaal = 0;

            for (int i = 0; i < worpen.Length; i++)
            {
                worpen[i] = rnd.Next(1, 7); // dobbelsteen 1 t/m 6
                totaal += worpen[i];
            }

            double gemiddelde = (double)totaal / worpen.Length;

            ViewBag.Worpen = worpen;
            ViewBag.Totaal = totaal;
            ViewBag.Gemiddelde = gemiddelde.ToString("0.00");

            return View();
        }
    }
}
