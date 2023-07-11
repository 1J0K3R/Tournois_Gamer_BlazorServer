using System.ComponentModel.DataAnnotations;

namespace Tournois_Gamer_BlazorServer.Data.Inscription;

public class Player
{
    public int Id { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "Name length can't be more than 8.")]
    public string Name { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "Name length can't be more than 8.")]
    public string FirstName { get; set; }

    public DateTime? DateBorn { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "Name length can't be more than 8.")]
    public string Pseudo { get; set; }
}
