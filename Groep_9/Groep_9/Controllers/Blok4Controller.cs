using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Groep_9.Controllers
{
    public class Blok4Controller : Controller
    {
        [HttpGet]
        public IActionResult Opdracht1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Opdracht1(int NummerEen, int NummerTwee)
        {
            string Antwoord;

            if (NummerEen > NummerTwee)
            {
                Antwoord = "Nummer een wint"; 
            } else if (NummerTwee > NummerEen)
            {
                Antwoord = "Nummer Twee wint";
            } else
            {
                Antwoord = "Beide getallen zijn gelijk";
            }
            ViewBag.Antwoord = Antwoord;
            return View();

        }
        [HttpGet]
        public IActionResult Opdracht2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Opdracht2(int GetalEen, int GetalTwee, int GetalDrie)
        {
            string Antwoord;

            if (GetalEen > GetalDrie && GetalTwee > GetalDrie)
            {
                Antwoord = "Het derde getal is de kleinste van de drie";
            } else
            {
                Antwoord = "Het derde getal is niet de kleinste van de drie";
            }
            ViewBag.Antwoord = Antwoord;
            return View();

        }

        [HttpGet]
        public IActionResult Opdracht3()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Opdracht3(int Getal)
        {
            string Antwoord;

            switch(Getal)
            {
                case 1:
                    Antwoord = "Klaveren";
                    break;

                case 2:
                    Antwoord = "Ruiten";
                    break;

                case 3:
                    Antwoord = "Harten";
                    break;

                case 4:
                    Antwoord = "Schoppen";
                    break;

                default:
                    Antwoord = "Alleen 1, 2, 3 of 4 is toegestaan";
                    break;
            }
            ViewBag.Antwoord = Antwoord;
            return View();
        }

        [HttpGet]
        public IActionResult Opdracht4()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Opdracht4(int Getal1, int Getal2)
        {
            string Antwoord;

            if (Getal1 % Getal2 == 0)
            {
                Antwoord = $"{Getal1} is deelbaar door {Getal2}";
            } else
            {
                Antwoord = $"{Getal1} is niet deelbaar door {Getal2}";
            }
            ViewBag.Antwoord = Antwoord;
            return View();
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
