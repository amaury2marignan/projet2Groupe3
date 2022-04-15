using Projet2Homechef.Models.Prestation;
using System.Collections.Generic;

namespace Projet2Homechef.Models
{
    public class Catalogue
    {
        public int Id { get; set; }
        public List<Chef> Chefs { get; set; }
        public List<Service> Services { get; set; }
                
    }
}
