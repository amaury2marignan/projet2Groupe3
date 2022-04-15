using System;

namespace Projet2Homechef.Models.Prestation
{
    public class Prestation
    {
        public int Id { get; set; }
        public Commande Commande { get; set; }
        public int Etat { get; set; }
        public DateTime Date { get; set; }
    }
}
