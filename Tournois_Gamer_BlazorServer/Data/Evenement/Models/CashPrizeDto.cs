namespace Tournois_Gamer_BlazorServer.Data.Evenement.Models;

public class CashPrizeDto
{
    /// <summary>
    /// Id de la récompense
    /// </summary>
    public int CashPrizeId { get; set; }

    /// <summary>
    /// Récompense du Vainqueur
    /// </summary>
    public int WinnersPrice { get; set; }

    /// <summary>
    /// Récompense du Finaliste
    /// </summary>
    public int FinalistPrice { get; set; }
}