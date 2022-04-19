using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2Homechef.Models
{
    public class Dal: IDal
    {
        private BddContext _bddContext;
        public Dal()
        {
            _bddContext = new BddContext();
        }

        public void DeleteCreateDatabase()
        {
            _bddContext.Database.EnsureDeleted();
            _bddContext.Database.EnsureCreated();
        }

        public void AjouterVillageois(string userName, string password, string nom, string prenom, DateTime dateDeNaissance, string email, string tel)
        {
            Villageois villageois = new Villageois() { UserName = userName, Password = password, Nom = nom, Prenom = prenom, DateDeNaissance = dateDeNaissance, Email = email, Tel = tel, Role = "Villageois", Valider =0 };
            _bddContext.Village.Add(villageois);
            _bddContext.SaveChanges();

        }

        public void CreerService(string titre, string description)
        {

            Service2 serviceToAdd = new Service2 { Titre = titre, Description = description };
            /*if (id != 0)
            {
                sejourToAdd.Id = id;
            }*/

            this._bddContext.Services.Add(serviceToAdd);
            this._bddContext.SaveChanges();
        }
        public List<Villageois> ObtientTousLesVillageois()
        {
            return _bddContext.Village.ToList();
        }

        public List<Villageois> VillageoisAValider()
        {
            return _bddContext.Village.ToList();
        }
        /*
                public int CreerSejour(string lieu, string telephone)
                {
                    Sejour sejour = new Sejour() { Lieu = lieu, Telephone = telephone };
                    _bddContext.Sejours.Add(sejour);
                    _bddContext.SaveChanges();
                    return sejour.Id;
                }

                public void ModifierSejour(int id, string lieu, string telephone)
                {
                    Sejour sejour = _bddContext.Sejours.Find(id);
                    if (sejour != null)
                    {
                        sejour.Lieu = lieu;
                        sejour.Telephone = telephone;

                        _bddContext.SaveChanges();
                    }
                }
        */
        public void SupprimerVillageois(int id)
        {
            Villageois villageois = _bddContext.Village.Find(id);
            if (villageois != null)
            {
                _bddContext.Village.Remove(villageois);
                _bddContext.SaveChanges();
            }
        }

        public void Dispose()
        {
            _bddContext.Dispose();
        }

        public void ValiderVillageois(int id)
        {
            Villageois villageois = _bddContext.Village.Find(id);
            if (villageois != null)
            {
                villageois.Valider=1;

                _bddContext.SaveChanges();
            }
        }

        public void ModifierVillageois(int idVillageoisAModifier, string userName, string password, string nom, string prenom, DateTime dateDeNaissance, string email, string tel)
        {
            Villageois villageois = _bddContext.Village.Find(idVillageoisAModifier);
            if (villageois != null)
            {
                villageois.UserName = userName;
                villageois.Password = password;
                villageois.Nom = nom;
                villageois.Prenom = prenom;
                villageois.DateDeNaissance = dateDeNaissance;
                villageois.Email = email;
                villageois.Tel = tel; 
                
                _bddContext.SaveChanges();
            }
}


    }
}
