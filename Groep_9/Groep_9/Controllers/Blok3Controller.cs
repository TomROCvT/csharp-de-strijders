using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Groep_9.Models;

namespace Groep_9.Controllers
{
    public class Blok3Controller : Controller
    {
        public IActionResult Opdracht1(Persoon persoon)
        {
            string TotaleNaam = persoon.Voornaam + persoon.Tussenvoegsel + persoon.Achternaam;

            int LengteNaam = TotaleNaam.Length;

            ViewBag.LengteNaam = LengteNaam;

            return View();

        }

        public IActionResult Opdracht2(DateTime GeboortedatumEen, DateTime GeboortedatumTwee)
        {
            TimeSpan Verschil = GeboortedatumEen - GeboortedatumTwee;

            ViewBag.Verschil = Math.Abs(Verschil.Days);

            return View();

        }

        public IActionResult Opdracht3(double hoogte, double lengte, double breedte)
        {
            double inhoud = hoogte * lengte * breedte;
            ViewBag.Inhoud = inhoud.ToString("0.00");
            return View();
        }

        public IActionResult Opdracht4(double euroBedrag)
        {
            // Actuele koersen van EUR naar andere valuta’s (op moment van schrijven)
            double eurToUsd = 1.1781;
            double eurToGbp = 0.87290;
            double eurToJpy = 174.17;
            double eurToChf = 0.9348;
            double eurToAud = 1.7865;

            var resultaten = new Dictionary<string, string>();

            // Berekeningen
            resultaten["USD"] = (euroBedrag * eurToUsd).ToString("0.00", CultureInfo.InvariantCulture);
            resultaten["GBP"] = (euroBedrag * eurToGbp).ToString("0.00", CultureInfo.InvariantCulture);
            resultaten["JPY"] = (euroBedrag * eurToJpy).ToString("0.00", CultureInfo.InvariantCulture);
            resultaten["CHF"] = (euroBedrag * eurToChf).ToString("0.00", CultureInfo.InvariantCulture);
            resultaten["AUD"] = (euroBedrag * eurToAud).ToString("0.00", CultureInfo.InvariantCulture);

            ViewBag.Resultaten = resultaten;
            ViewBag.EuroBedrag = euroBedrag.ToString("0.00", CultureInfo.InvariantCulture);

            return View();
        }
    }
}
