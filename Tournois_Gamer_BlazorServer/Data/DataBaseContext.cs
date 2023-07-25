using Microsoft.EntityFrameworkCore;

using Tournois_Gamer_BlazorServer.Data.Evenement.Models;
using Tournois_Gamer_BlazorServer.Data.Inscription;

namespace Tournois_Gamer_BlazorServer.Data;

public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=tcp:sqlesportdb.database.windows.net,1433;Initial Catalog=EsportDb;Persist Security Info=False;User ID=adminsys;Password=85EmQeEafTbL83lA8y;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }

    public DbSet<EventDto> EventDtos { get; set; }

    public DbSet<PlayerDto> PlayerDto { get; set; }
    public DbSet<InscriptionIndividualDto> InscriptionIndividualDto { get; set; }
    public DbSet<InscriptionTeamDto> InscriptionTeamDto { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<EventDto>()
            .OwnsOne(owner => owner.Schedules, naviguationBuilder =>
            {
                naviguationBuilder.ToJson();
            });

        modelBuilder.Entity<InscriptionTeamDto>()
            .HasMany(e => e.Players);

        //modelBuilder.Entity<InscriptionTeamDto>()
        //    .HasOne(e => e.PlayersIdCaptain).WithOne(e => e.InscriptionTeamDto);

        base.OnModelCreating(modelBuilder);
    }
}

/*
 * 
 * Pour update la base de données (La vrai) => dotnet ef database update
 * 
 * Pour faire une migration en local vers le dossier "Migrations" => dotnet ef migrations add "InitialMigrationV3"
 *
 */