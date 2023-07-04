namespace Tournois_Gamer_BlazorServer.Data;

public class EventServices
{
    private Dictionary<int, Tournament> Tournaments { get; set; }
    private Dictionary<int, EngagementTerms> EngagementTermsDictionnary { get; set; }
    private void GetTournament()
    {
        Dictionary<int, Tournament> tournaments = new()
        {
            {
                0,
                new Tournament()
                {
                    Id = 0,
                    Name = "League Of Legends"
                }
            },
            {
                1,
                new Tournament (){
                    Id = 1,
                    Name = "FIFA par équipe"
                }
            },
            {
                2,
                new Tournament (){
                    Id = 2,
                    Name = "FIFA individuel"
                }
            }
        };

        Tournaments = tournaments;
    }
    private void GetEngagementTerms()
    {
        Dictionary<int, EngagementTerms> engagementTerms = new()
        {
            {
                0,
                new EngagementTerms()
                {
                    Id = 0,
                    Tournament = Tournaments.GetValueOrDefault(0)!,
                    TeamNbr = 32,
                    PlayerNbrPerTeam = 5,
                    Platform = "PC",
                    CostEntry = 100,
                    CashPrize = new CashPrize()
                    {
                        Id = 0,
                        WinnersPrice = 5000,
                        FinalistPrice = 2000
                    }
                }
            },{
                1,
                new EngagementTerms()
                {
                    Id = 1,
                    Tournament = Tournaments.GetValueOrDefault(1)!,
                    TeamNbr = 64,
                    PlayerNbrPerTeam = 2,
                    Platform = "PS5",
                    CostEntry = 30,
                    CashPrize = new CashPrize()
                    {
                        Id = 1,
                        WinnersPrice = 3000,
                        FinalistPrice = 1500
                    }
                }
            },
            {
                2,
                new EngagementTerms()
                {
                    Id = 2,
                    Tournament = Tournaments.GetValueOrDefault(1)!,
                    TeamNbr = 64,
                    PlayerNbrPerTeam = 2,
                    Platform = "XBOX",
                    CostEntry = 30,
                    CashPrize = new CashPrize()
                    {
                        Id = 2,
                        WinnersPrice = 3000,
                        FinalistPrice = 1500
                    }
                }
            },

            {
                3,
                new EngagementTerms()
                {
                    Id = 3,
                    Tournament = Tournaments.GetValueOrDefault(2)!,
                    TeamNbr = 128,
                    PlayerNbrPerTeam = 1,
                    Platform = "PS5",
                    CostEntry = 15,
                    CashPrize = new CashPrize()
                    {
                        Id = 3,
                        WinnersPrice = 2000,
                        FinalistPrice = 1000
                    }
                }
            },
            {
                4,
                new EngagementTerms()
                {
                    Id = 4,
                    Tournament = Tournaments.GetValueOrDefault(2)!,
                    TeamNbr = 128,
                    PlayerNbrPerTeam = 1,
                    Platform = "XBOX",
                    CostEntry = 15,
                    CashPrize = new CashPrize()
                    {
                        Id = 4,
                        WinnersPrice = 2000,
                        FinalistPrice = 1000
                    }
                }
            }
        };
        EngagementTermsDictionnary = engagementTerms;
    }

    public Task<Event> GetEventAsync()
    {
        GetTournament();
        GetEngagementTerms();

        return Task.FromResult(new Event()
        {
            Id = 0,
            Name = "LYON E-SPORT",
            DatesString = "Du 15 au 17 Septembre 2023",
            Schedule = {
                "Le 15 septembre 2023 de 17h à 22h",
                "Le 16 septembre 2023 de 10h à 22h",
                "Le 17 septembre 2023 de 10h à 18h"
            },
            Place = "Palais des Sports Gerland – Lyon 69007",
            Tournaments =
            {
                Tournaments.GetValueOrDefault(0)!,
                Tournaments.GetValueOrDefault(1)!,
                Tournaments.GetValueOrDefault(2)!,
            },
            EngagementTermsList =
            {
                EngagementTermsDictionnary.GetValueOrDefault(0)!,
                EngagementTermsDictionnary.GetValueOrDefault(1)!,
                EngagementTermsDictionnary.GetValueOrDefault(2)!,
                EngagementTermsDictionnary.GetValueOrDefault(3)!,
                EngagementTermsDictionnary.GetValueOrDefault(4)!
            },
            Capacity = 13000,
            Description = "A l’occasion de cet événement « Lyon Esport », vous remarquerez dans le tableau ci-dessus que seuls les deux premiers de chaque tournoi sont primés. Mais pour d’autres événements, l’organisateur peut décider de primer n’importe quel classement."
        });
    }
}
