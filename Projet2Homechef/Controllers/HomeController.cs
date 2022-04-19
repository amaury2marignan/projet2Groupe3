using Microsoft.AspNetCore.Mvc;
using Projet2Homechef.Models;
using System;

namespace Projet2Homechef.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult CreerAdhesion()
        {

           return View("Index");
        }

        [HttpPost]
        public IActionResult CreerAdhesion(string userName, string password, string nom, string prenom, DateTime dateDeNaissance, string email, string tel)
        {

            using (Dal dal = new Dal())
            {
                dal.AjouterVillageois(userName, password, nom, prenom, dateDeNaissance, email, tel);
            }

            return RedirectToAction("index");
        }


        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Test2()
        {
            return View();
        }

        public IActionResult Village()
        {
            return View();
        }


    }
}
