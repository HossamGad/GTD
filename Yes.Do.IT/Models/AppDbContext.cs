using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Yes.Do.IT.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public DbSet<NyUppgift> DbNyUppgift { get; set; }

        public DbSet<Uppgifter> Uppgifter { get; set; }
        public DbSet<MinLista> MinLista { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<MinLista>().HasData(new MinLista { MinListaId = 1, MinListaNamn = "Idag" });
            modelBuilder.Entity<MinLista>().HasData(new MinLista { MinListaId = 2, MinListaNamn = "Imorgon" });
            modelBuilder.Entity<MinLista>().HasData(new MinLista { MinListaId = 3, MinListaNamn = "Nästa Vecka" });


            modelBuilder.Entity<Uppgifter>().HasData(new Uppgifter
            {
                UppgiftId = 1,
                UppgiftNamn = "Idag",
                Text = "Uppgifter som ska görs idag",
                MinListaId = 1,
            });

            modelBuilder.Entity<Uppgifter>().HasData(new Uppgifter
            {
                UppgiftId = 2,
                UppgiftNamn = "Imorgon",
                Text = "Uppgifter som ska görs imorgon",
                MinListaId = 2,
            });
            modelBuilder.Entity<Uppgifter>().HasData(new Uppgifter
            {
                UppgiftId = 3,
                UppgiftNamn = "Nästa Vecka",
                Text = "Uppgifter som ska görs nästa vecka",
                MinListaId = 3,
            });

            
        }
    }
}
