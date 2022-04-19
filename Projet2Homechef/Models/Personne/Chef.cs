using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Projet2Homechef.Models
{
    public class Chef
    {
        public int Id { get; set; }
        public virtual List<Service2> Service { get; set; }
    }
}
