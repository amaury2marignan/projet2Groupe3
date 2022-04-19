using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2Homechef.Models
{
    public interface IDal: IDisposable
    {
        void DeleteCreateDatabase();
        public void AjouterVillageois(string userName, string password, string nom, string prenom, DateTime dateDeNaissance, string email, string tel);
        public void CreerService(string Titre, string Description);
        
    }
}
