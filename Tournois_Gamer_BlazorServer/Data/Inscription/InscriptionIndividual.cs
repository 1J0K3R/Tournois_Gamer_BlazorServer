using System.ComponentModel.DataAnnotations;

using Tournois_Gamer_BlazorServer.Data.Evenement;

namespace Tournois_Gamer_BlazorServer.Data.Inscription;

public class InscriptionIndividual
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public Tournament Tournament { get; set; }

    [Required]
    public Player Player { get; set; }
}
