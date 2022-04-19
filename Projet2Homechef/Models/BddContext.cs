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
        public DbSet<Service2> Services { get; set; }
        public DbSet<Catalogue> Catalogue { get; set; }
       /* public DbSet<Sejour> Sejours { get; set; }*/

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villageois>()
                .HasIndex(b => b.ChefId)
                .IsUnique();
        }*/

        public void InitializeDb()
        {
            this.Database.EnsureDeleted();
            this.Database.EnsureCreated();
            this.Village.AddRange(
               /* new Villageois
                {
                    Id = 1,
                    Nom = "Bucharati",
                    Prenom = "Luigi"
                },
                new Villageois
                {
                    Id = 2,
                    Nom = "Yugioh",
                    Prenom = "ohoh"
                },
                new Villageois
                {
                    Id = 3,
                    Nom = "Master",
                    Prenom = "Chief"
                }*/
            );
            this.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=RRRRR;database=homechef");
        }
    }
}
