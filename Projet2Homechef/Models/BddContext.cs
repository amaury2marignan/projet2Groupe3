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
              
               new Villageois
               {
                 
                   UserName = "111",
                   Password = "azerty",
                   Nom = "Bucharati",
                   Prenom = "Luigi",
                   DateDeNaissance = new DateTime(1990,03,02),
                   Email = "aa@hotmail.com",
                   Tel = "0123456789",
                   Role = "Villageois",
                   Valider = 0
               },
              new Villageois
              {
                
                  UserName = "333",
                  Password = "azerty",
                  Nom = "Gloup",
                  Prenom = "Luigi",
                  DateDeNaissance = new DateTime(1990, 03, 02),
                  Email = "aa@hotmail.com",
                  Tel = "0123456789",
                  Role = "Villageois",
                  Valider = 0

              },

                new Villageois
                {
                   
                    UserName = "444",
                    Password = "azerty",
                    Nom = "Fra ncois",
                    Prenom = "Luigi",
                    DateDeNaissance = new DateTime(1990, 03, 02),
                    Email = "aa@hotmail.com",
                    Tel = "0123456789",
                    Role = "Villageois",
                    Valider = 0

                },
                  new Villageois
                  {

                      UserName = "555",
                      Password = "azerty",
                      Nom = "FFF",
                      Prenom = "Luigi",
                      DateDeNaissance = new DateTime(1990, 03, 02),
                      Email = "aa@hotmail.com",
                      Tel = "0123456789",
                      Role = "Villageois",
                      Valider = 0

                  },
                    new Villageois
                    {

                        UserName = "3EE",
                        Password = "azerty",
                        Nom = "prrr",
                        Prenom = "Luigi",
                        DateDeNaissance = new DateTime(1990, 03, 02),
                        Email = "aa@hotmail.com",
                        Tel = "0123456789",
                        Role = "Villageois",
                        Valider = 0

                    },
                      new Villageois
                      {

                          UserName = "4gg4",
                          Password = "azerty",
                          Nom = "FFF",
                          Prenom = "Luigi",
                          DateDeNaissance = new DateTime(1990, 03, 02),
                          Email = "aa@hotmail.com",
                          Tel = "0123456789",
                          Role = "Villageois",
                          Valider = 0

                      }

            );
            this.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;user id=root;password=RRRRR;database=homechef");
        }
    }
}
