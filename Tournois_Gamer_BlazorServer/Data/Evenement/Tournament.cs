namespace Tournois_Gamer_BlazorServer.Data.Evenement;

public class Tournament
{
    /// <summary>
    /// Id du tournois
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nom du tournois 
    /// </summary>
    public TournamentName TournamentName { get; set; }

    /// <summary>
    /// Nombre d'équipe 
    /// </summary>
    public int TeamNbr { get; set; }

    /// <summary>
    /// Nombre de joueur par équipe
    /// </summary>
    public int PlayerNbrPerTeam { get; set; }

    /// <summary>
    /// Plateform
    /// </summary>
    public string Platform { get; set; }

    /// <summary>
    /// Prix d'entrée
    /// </summary>
    public int CostEntry { get; set; }

    /// <summary>
    /// Récompense 
    /// </summary>
    public CashPrize CashPrize { get; set; }

    /// <summary>
    /// Tournois en équipe ? Ou individuel ?
    /// </summary>
    public bool IsTeam { get; set; }
}
