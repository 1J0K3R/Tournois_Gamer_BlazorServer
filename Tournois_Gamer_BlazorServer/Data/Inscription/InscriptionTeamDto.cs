using System.ComponentModel.DataAnnotations;
using Tournois_Gamer_BlazorServer.Data.Evenement.Models;

namespace Tournois_Gamer_BlazorServer.Data.Inscription;

public class InscriptionTeamDto
{
    public int InscriptionTeamDtoId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public TournamentDto Tournament { get; set; }

    [Required]
    [ValidateComplexType]
    public List<PlayerDto> Players { get; set; } = new();

    [Required]
    public PlayerDto PlayersIdCaptain { get; set; }
}
