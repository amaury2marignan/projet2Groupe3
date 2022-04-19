using Microsoft.AspNetCore.Mvc;
using Projet2Homechef.Models;
using System.Collections.Generic;
using System.Linq;

namespace Projet2Homechef.Controllers
{
    public class GestionnaireController : Controller
    {
        public IActionResult Gestionnaire()

        {
            Dal dal = new Dal();
            List<Villageois> listeDesVillageoisAValider = dal.ObtientTousLesVillageois().Where(v=>v.Valider==0).ToList();

            return View(listeDesVillageoisAValider);
        }


        public IActionResult DeleteVillageois(int id)

        {
            Dal dal = new Dal();
            dal.SupprimerVillageois(id);

            return RedirectToAction("Gestionnaire");
        }
    
        public IActionResult ValiderVillageois(int id)

        {
            Dal dal = new Dal();
            dal.ValiderVillageois(id);

            return RedirectToAction("Gestionnaire");
        }
    }
}
