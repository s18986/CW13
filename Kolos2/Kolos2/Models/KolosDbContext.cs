using Kolos2.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos2.Models
{
    public class KolosDbContext : DbContext
    {
        public DbSet<Klient> Klients { get;set;}
        public DbSet<Pracownik> Pracowniks { get; set; }
        public DbSet<Zamowienie> Zamowienies { get; set; }
        public DbSet<WyrobCukierniczy> WyrobCukierniczies { get; set; }

        public DbSet<Zamowienie_WyrobCukierniczy> zamowienie_WyrobCukierniczies { get; set; }
        KolosDbContext()
    {

    }
        public KolosDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //dodawanie wlasciwosci
            modelBuilder.ApplyConfiguration(new Zamowienie_WyrobCukierniczyConfiguration());
            modelBuilder.ApplyConfiguration(new ZamowienieConfiguration());

        }
    }
}
