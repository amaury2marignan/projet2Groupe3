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
        /*public void SupprimerSejour(int id)
        {
            Sejour sejour = _bddContext.Sejours.Find(id);
            if (sejour != null)
            {
                _bddContext.Sejours.Remove(sejour);
                _bddContext.SaveChanges();
            }
        }*/

        public void Dispose()
        {
            _bddContext.Dispose();
        }

    }
}
