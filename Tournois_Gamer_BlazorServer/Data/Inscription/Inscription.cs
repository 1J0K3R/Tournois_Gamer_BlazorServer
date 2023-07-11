using Tournois_Gamer_BlazorServer.Data.Evenement;

namespace Tournois_Gamer_BlazorServer.Data.Inscription;

public class Inscription
{
    public int Id { get; set; }

    public bool IsTeam { get; set; }

    public string Name { get; set; }

    public Tournament Tournament { get; set; }

    public List<Player> Players { get; set; }

    public int PlayersIdCaptain { get; set; }
}
