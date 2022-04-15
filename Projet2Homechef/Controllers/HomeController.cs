using Microsoft.AspNetCore.Mvc;
using Projet2Homechef.Models;

namespace Projet2Homechef.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    public void Adhesion(Villageois villageois)
    {
        Villageois nouveauVillageois = new Villageois() { Nom}
    }
}
