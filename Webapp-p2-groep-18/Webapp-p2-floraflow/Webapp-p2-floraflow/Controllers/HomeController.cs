using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Webapp_p2_floraflow.Models;

namespace Webapp_p2_floraflow.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Plants()
        {

            return View();
        }
        public IActionResult Pots()
        {

            return View();
        }
       /* public IActionResult Check(string button)
        {
            if (button=="first")
            {
                TempData["buttonval"] = "flamingoplant ";
            }
            else
            {
                TempData["buttonval"] = "citroenplant";
            }
            return RedirectToAction();
        }*/
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       /* public ActionResult pots()
        {
            var plant = new List<Plants>
            {
                new Plants {Plant_name = "flamingoplant",Use_of_water = 250,Time_delay = 604800000,Plant_description ="Anthurium of flamingoplant is een tropische plant die erg populair is als kamerplant. Dat heeft meerdere redenen: de anthuriums zijn gemakkelijk in onderhoud en daarnaast zijn ze in veel verschillende kleuren beschikbaar. Door de kleur en vorm zal de anthurium echt opvallen in uw huis!"}

            }


        }*/

    }
   


    /*public class Plants
    {
        public string Plant_name { get; set; }
        public int Use_of_water { get; set; }
        public int Time_delay { get; set; }
        public string Plant_description { get; set; }

        public Plants(string name, int water, int milliseconds, string description)
        {
            this.Plant_name = name;
            this.Use_of_water = water;
            this.Time_delay = milliseconds;
            this.Plant_description = description;

        }

    }*/


    /*public class Importplants
    {
        public static List<Plants> CreatePlants(List<Plants> plants)
        {
            Plants Flamingoplant = new Plants("flamingoplant", 250, 604800000, "Anthurium of flamingoplant is een tropische plant die erg populair is als kamerplant. Dat heeft meerdere redenen: de anthuriums zijn gemakkelijk in onderhoud en daarnaast zijn ze in veel verschillende kleuren beschikbaar. Door de kleur en vorm zal de anthurium echt opvallen in uw huis!");

            plants.AddRange(new List<Plants> { Flamingoplant });


        }

    }

    public class Pots
    {

        public string ID { get; set; }
        public int Ammount { get; set; }
        public string Plant_name { get; set; }
        public int Use_of_water { get; set; }
        public int Time_delay { get; set; }
        public string Plant_description { get; set; }

        public Pots(string id, int ammount, string name, int water, int milliseconds, string description)
        {
            this.ID = id;
            this.Ammount = ammount;
            this.Plant_name = name;
            this.Use_of_water = water;
            this.Time_delay = milliseconds;
            this.Plant_description = description;


        }
    }
    public class Methode
    {


        private static string Inname;
        private static int Inwater;
        private static int Indelay;
        private static string Ininfo;


        public string Updatepot(Plants plant)
        {
            Inname = plant.Plant_name;
            Inwater = plant.Use_of_water;
            Indelay = plant.Time_delay;
            Ininfo = plant.Plant_description;

        }


        public static List<Pots> CreatePots(List<Pots> pots)
        {
            Pots Pot_1 = new Pots("1", 1, Inname, Inwater, Indelay, Ininfo);
            pots.AddRange(new List<Pots> { Pot_1 });

            return pots;
        }
    }*/


}
