using System;

namespace Projet2Homechef.Models.Prestation
{
    public class Commande
    {
        public int Id { get; set; }
        public Devis Devis { get; set; }
        public DateTime Date { get; set; }
        public Villageois Villageois { get; set; }
    }
}
