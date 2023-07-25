using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Tournois_Gamer_BlazorServer.Data.Evenement.Models;

namespace Tournois_Gamer_BlazorServer.Data.Evenement.Configuration;

public class EventDtoConfiguration : IEntityTypeConfiguration<EventDto>
{
    public void Configure(EntityTypeBuilder<EventDto> builder)
    {
        builder.ToTable("Event");

        builder.HasKey(p => p.Id);
    }
}
