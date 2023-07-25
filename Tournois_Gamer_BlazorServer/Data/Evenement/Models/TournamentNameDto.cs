namespace Tournois_Gamer_BlazorServer.Data.Evenement.Models;

public class TournamentNameDto
{
    /// <summary>
    /// Id du nom du tournois 
    /// </summary>
    public int TournamentNameId { get; set; }

    /// <summary>
    /// Nom du tournois
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int EventId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public EventDto Event { get; set; }
}
