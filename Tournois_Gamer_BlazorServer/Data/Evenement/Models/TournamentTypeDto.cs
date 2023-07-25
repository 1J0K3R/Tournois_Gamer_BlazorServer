namespace Tournois_Gamer_BlazorServer.Data.Evenement.Models;

public class TournamentTypeDto
{
    /// <summary>
    /// Id du nom du tournois 
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nom du tournois
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public List<TournamentDto> Tournaments { get; set; }
}
