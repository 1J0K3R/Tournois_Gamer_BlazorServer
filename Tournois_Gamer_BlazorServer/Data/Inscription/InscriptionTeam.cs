using System.ComponentModel.DataAnnotations;

using Tournois_Gamer_BlazorServer.Data.Evenement;

namespace Tournois_Gamer_BlazorServer.Data.Inscription;

public class InscriptionTeam
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public Tournament Tournament { get; set; }

    [Required]
    public List<Player> Players { get; set; } = new();

    [Required]
    public int PlayersIdCaptain { get; set; }
}
