using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Projet2Homechef.Models
{
    public class Chef
    {
        public int Id { get; set; }
        public virtual List<Service> Service { get; set; }
    }
}
