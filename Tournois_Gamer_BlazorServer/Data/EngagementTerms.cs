namespace Tournois_Gamer_BlazorServer.Data;

public class EngagementTerms
{
    public int Id { get; set; }

    public Tournament Tournament { get; set; }

    public int TeamNbr { get; set; }

    public int PlayerNbrPerTeam { get; set; }

    public string Platform { get; set; }

    public int CostEntry { get; set; }

    public CashPrize CashPrize { get; set; }
}
