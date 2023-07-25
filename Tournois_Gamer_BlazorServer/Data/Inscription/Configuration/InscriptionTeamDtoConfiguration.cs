using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tournois_Gamer_BlazorServer.Data.Inscription.Configuration;

public class InscriptionTeamDtoConfiguration : IEntityTypeConfiguration<InscriptionTeamDto>
{
    public void Configure(EntityTypeBuilder<InscriptionTeamDto> builder)
    {
        builder.ToTable("InscriptionTeam");

        builder.HasKey(p => p.Id);
    }
}
