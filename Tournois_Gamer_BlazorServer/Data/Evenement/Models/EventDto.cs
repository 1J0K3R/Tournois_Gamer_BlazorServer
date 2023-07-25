namespace Tournois_Gamer_BlazorServer.Data.Evenement.Models;

public class EventDto
{
    /// <summary>
    /// Identifiant de l'evenement /!\ Devrait surement ne pas apparaitre ici mais etre dans la base de données auto incrémenter. /!\
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// Nom de l'evenement 
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Date de l'evenement au format string 
    /// </summary>
    public string DatesString { get; set; }

    /// <summary>
    /// List des Horaires
    /// </summary>
    public List<string> Schedules { get; set; }

    /// <summary>
    /// Lieu 
    /// </summary>
    public string Place { get; set; }

    /// <summary>
    /// Liste des noms de tournois 
    /// </summary>
    public List<TournamentNameDto> TournamentNameList { get; set; }

    /// <summary>
    /// Liste des tournois
    /// </summary>
    public List<TournamentDto> TournamentList { get; set; }

    /// <summary>
    /// Capacité
    /// </summary>
    public int Capacity { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Description { get; set; }
}
