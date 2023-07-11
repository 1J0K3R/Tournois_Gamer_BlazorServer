namespace Tournois_Gamer_BlazorServer.Data.Evenement;

public class Event
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string DatesString { get; set; }

    public List<string> Schedule { get; set; }

    public string Place { get; set; }

    public List<Tournament> Tournaments { get; set; }

    public List<EngagementTerms> EngagementTermsList { get; set; }

    public int Capacity { get; set; }

    public string Description { get; set; }
}
