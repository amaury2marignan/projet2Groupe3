using Projet2Homechef.Models.Prestation;
using System.Collections.Generic;

namespace Projet2Homechef.Models
{
    public class Service
    {
        public int Id { get; set; }
        public Chef Chef { get; set; }
        public List<Lieu> Lieux { get; set; }
        public List<Outil> Outils { get; set; }
        public List<Talent> Talents { get; set; }

    }
}
