using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace Yes.Do.IT.Models
{
    public class MinListaContext : DbContext
    {
        private readonly IConfiguration _config;

        public MinListaContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }
        public DbSet<MinLista> Minlista { get; set; }

        protected override void OnModelCreating(ModelBuilder bldr)
        {
            bldr.Entity<MinLista>()
              .HasData(new
              {
                  Name = "Uppgift 1",
                  Beskrivning = "Kolla på arbetsuppgifter"

              });

            bldr.Entity<MinLista>()
              .HasData(new
              {
                  Name = "Uppgift 2",
                  Beskrivning = "Planera din dag"
              });

            bldr.Entity<MinLista>()
              .HasData(new
              {
                  Name = "Uppgift 3",
                  Beskrivning = "Klara arbetsuppgifter"
              });
        }
    }
}
