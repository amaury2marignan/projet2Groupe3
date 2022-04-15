using Projet2Homechef.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet2Homechef.Models
{
    public class BddContext: DbContext
    {
        public DbSet<Villageois> Village { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Catalogue> Catalogue { get; set; }
       /* public DbSet<Sejour> Sejours { get; set; }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villageois>()
                .HasIndex(b => b.ChefId)
                .IsUnique();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=RRRRR;database=homechef");
        }
    }
}
