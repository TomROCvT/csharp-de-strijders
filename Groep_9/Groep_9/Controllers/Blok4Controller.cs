using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Groep_9.Controllers
{
    public class Blok4Controller : Controller
    {
        public IActionResult Opdracht1()
        {

            string test = "Hoi";
            return View("Opdracht1", test);

            //code van opdracht 1 hier

        }

        public IActionResult Opdracht5(int score)
        {
            string grade;

            if (score >= 97) grade = "A+";
            else if (score >= 93) grade = "A";
            else if (score >= 90) grade = "A-";
            else if (score >= 87) grade = "B+";
            else if (score >= 83) grade = "B";
            else if (score >= 80) grade = "B-";
            else if (score >= 77) grade = "C+";
            else if (score >= 73) grade = "C";
            else if (score >= 70) grade = "C-";
            else if (score >= 67) grade = "D+";
            else if (score >= 63) grade = "D";
            else if (score >= 60) grade = "D-";
            else grade = "F";

            bool behaald = grade.StartsWith("A") || grade.StartsWith("B") || grade.StartsWith("C");

            ViewBag.Score = score;
            ViewBag.Grade = grade;
            ViewBag.Behaald = behaald ? "✅ Ja, vak is behaald." : "❌ Nee, vak niet behaald.";

            return View();
        }

        public IActionResult Opdracht6(int werkuren, int leeftijd, int storingen)
        {
            bool vervangen = (werkuren > 10000) || (leeftijd >= 7) || (storingen > 25);

            ViewBag.Werkuren = werkuren;
            ViewBag.Leeftijd = leeftijd;
            ViewBag.Storingen = storingen;
            ViewBag.Vervangen = vervangen
                ? "❌ De draaibank moet vervangen worden."
                : "✅ De draaibank hoeft nog niet vervangen te worden.";

            return View();
        }

        public IActionResult Opdracht7()
        {
            DateTime nu = DateTime.Now;

            string begroeting;
            if (nu.Hour < 12)
                begroeting = "Goedemorgen";
            else if (nu.Hour < 18)
                begroeting = "Goedemiddag";
            else
                begroeting = "Goedenavond";

            bool isWeekend = (nu.DayOfWeek == DayOfWeek.Saturday || nu.DayOfWeek == DayOfWeek.Sunday);
            string soortDag = isWeekend ? "weekend" : "werkdag";

            ViewBag.Bericht = $"{begroeting}, het is vandaag een {soortDag}. ({nu:dddd HH:mm})";

            return View();
        }

        public IActionResult Opdracht8(int keuze)
        {
            int maandNummer = DateTime.Now.Month;

            string maand = "";
            string resultaat = "";

            switch (keuze)
            {
                case 1: // Nederlands
                    maand = new[]
                    { "Januari", "Februari", "Maart", "April", "Mei", "Juni",
                      "Juli", "Augustus", "September", "Oktober", "November", "December"}[maandNummer - 1];
                    resultaat = $"De huidige maand is {maand}.";
                    break;

                case 2: // Duits
                    maand = new[]
                    { "Januar", "Februar", "März", "April", "Mai", "Juni",
                      "Juli", "August", "September", "Oktober", "November", "Dezember"}[maandNummer - 1];
                    resultaat = $"Der aktuelle Monat ist {maand}.";
                    break;

                case 3: // Engels
                    maand = new[]
                    { "January", "February", "March", "April", "May", "June",
                      "July", "August", "September", "October", "November", "December"}[maandNummer - 1];
                    resultaat = $"The current month is {maand}.";
                    break;

                case 4: // Frans
                    maand = new[]
                    { "janvier", "février", "mars", "avril", "mai", "juin",
                      "juillet", "août", "septembre", "octobre", "novembre", "décembre"}[maandNummer - 1];
                    resultaat = $"Le mois en cours est {maand}.";
                    break;

                case 5: // Spaans
                    maand = new[]
                    { "enero", "febrero", "marzo", "abril", "mayo", "junio",
                      "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"}[maandNummer - 1];
                    resultaat = $"El mes actual es {maand}.";
                    break;

                case 6: // Eigen keuze → Turks
                    maand = new[]
                    { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran",
                      "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık"}[maandNummer - 1];
                    resultaat = $"Bu ay {maand} ayı.";
                    break;

                default:
                    resultaat = "Ongeldige keuze.";
                    break;
            }

            ViewBag.Resultaat = resultaat;
            return View();
        }
    }
}
