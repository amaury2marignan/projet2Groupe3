using Microsoft.AspNetCore.Mvc;
using Projet2Homechef.Models;
using System.Collections.Generic;
using System.Linq;

namespace Projet2Homechef.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()

        {
            Dal dal = new Dal();
            List<Villageois> listeDesVillageois = dal.ObtientTousLesVillageois().ToList();

            // return View(listeDesVillageois);
            return View();
        }


        public IActionResult DeleteVillageois(int id)

        {
            Dal dal = new Dal();
            dal.SupprimerVillageois(id);

            return RedirectToAction("Admin");
        }

        public IActionResult FormulaireVillageois(Villageois villageois)

        {
            Dal dal = new Dal();
            List<Villageois> listeDesVillageoisAvecCetId = dal.ObtientTousLesVillageois().Where(v => v.Id == villageois.Id).ToList();

            return View(listeDesVillageoisAvecCetId);

        }

       
    }
}