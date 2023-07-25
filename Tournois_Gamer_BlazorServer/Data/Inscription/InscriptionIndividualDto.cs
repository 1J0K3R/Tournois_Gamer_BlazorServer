using System.ComponentModel.DataAnnotations;
using Tournois_Gamer_BlazorServer.Data.Evenement.Models;

namespace Tournois_Gamer_BlazorServer.Data.Inscription;

public class InscriptionIndividualDto
{
    public int InscriptionIndividualDtoId { get; set; }

    [Required(ErrorMessage = "La séléction du tournois est requise.")]
    public TournamentDto Tournament { get; set; }

    [Required]
    [ValidateComplexType]
    public PlayerDto Player { get; set; }
}
