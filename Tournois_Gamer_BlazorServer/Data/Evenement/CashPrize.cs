namespace Tournois_Gamer_BlazorServer.Data.Evenement;

public class CashPrize
{
    /// <summary>
    /// Id de la récompense
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Récompense du Vainqueur
    /// </summary>
    public int WinnersPrice { get; set; }

    /// <summary>
    /// Récompense du Finaliste
    /// </summary>
    public int FinalistPrice { get; set; }
}