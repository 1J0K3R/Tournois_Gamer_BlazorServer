using System.ComponentModel.DataAnnotations;

namespace Tournois_Gamer_BlazorServer.Data.Inscription;

public class PlayerDto
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Le nom doit être renseigné.")]
    [StringLength(20, ErrorMessage = "Le Nom ne doit pas faire plus de 20 caractères.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Le prénom doit être renseigné.")]
    [StringLength(20, ErrorMessage = "Le Prénom ne doit pas faire plus de 20 caractères.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "La date de naissance doit être renseigné.")]
    public DateTime? DateBorn { get; set; }

    [Required(ErrorMessage = "Le pseudo doit être renseigné.")]
    [StringLength(20, ErrorMessage = "Le Pseudo ne doit pas faire plus de 20 caractères.")]
    public string Pseudo { get; set; }

    //public int? InscriptionTeamDtoId { get; set; }
    //public InscriptionTeamDto? InscriptionTeamDto { get; set; }
}
