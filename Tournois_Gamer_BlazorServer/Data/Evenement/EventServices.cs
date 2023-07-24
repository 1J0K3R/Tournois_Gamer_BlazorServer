

namespace Tournois_Gamer_BlazorServer.Data.Evenement;

public class EventServices
{
    private Dictionary<int, TournamentName> _TournamentNameDictionnary { get; set; } = new();
    private Dictionary<int, Tournament> _TournamentDictionnary { get; set; } = new();
    private Dictionary<int, TournamentName> GetTournamentNameDictionnary()
    {
        Dictionary<int, TournamentName> tournaments = new()
        {
            {
                0,
                new TournamentName()
                {
                    Id = 0,
                    Name = "League Of Legends"
                }
            },
            {
                1,
                new TournamentName (){
                    Id = 1,
                    Name = "FIFA par équipe"
                }
            },
            {
                2,
                new TournamentName (){
                    Id = 2,
                    Name = "FIFA individuel"
                }
            }
        };

        return tournaments;
    }
    private Dictionary<int, Tournament> GetEngagementDictionnary()
    {
        Dictionary<int, Tournament> engagementTerms = new()
        {
            {
                0,
                new Tournament()
                {
                    Id = 0,
                    TournamentName = _TournamentNameDictionnary.GetValueOrDefault(0)!,
                    IsTeam = true,
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
                new Tournament()
                {
                    Id = 1,
                    TournamentName = _TournamentNameDictionnary.GetValueOrDefault(1)!,
                    IsTeam = true,
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
                new Tournament()
                {
                    Id = 2,
                    TournamentName = _TournamentNameDictionnary.GetValueOrDefault(1)!,
                    IsTeam = true,
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
                new Tournament()
                {
                    Id = 3,
                    TournamentName = _TournamentNameDictionnary.GetValueOrDefault(2)!,
                    IsTeam = false,
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
                new Tournament()
                {
                    Id = 4,
                    TournamentName = _TournamentNameDictionnary.GetValueOrDefault(2)!,
                    IsTeam = false,
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
        return engagementTerms;
    }
    public Task<Event> GetEventAsync()
    {
        _TournamentNameDictionnary = GetTournamentNameDictionnary();
        _TournamentDictionnary = GetEngagementDictionnary();

        Event eventa = new()
        {
            Id = 0,
            Name = "LYON E-SPORT",
            DatesString = "Du 15 au 17 Septembre 2023",
            Schedules = new List<string>{
                "Le 15 septembre 2023 de 17h à 22h",
                "Le 16 septembre 2023 de 10h à 22h",
                "Le 17 septembre 2023 de 10h à 18h"
            },
            Place = "Palais des Sports Gerland – Lyon 69007",
            TournamentNameList = new List<TournamentName> {
                _TournamentNameDictionnary.GetValueOrDefault(0)!,
                _TournamentNameDictionnary.GetValueOrDefault(1)!,
                _TournamentNameDictionnary.GetValueOrDefault(2)!,
            },
            TournamentList = new List<Tournament>{
                _TournamentDictionnary.GetValueOrDefault(0)!,
                _TournamentDictionnary.GetValueOrDefault(1)!,
                _TournamentDictionnary.GetValueOrDefault(2)!,
                _TournamentDictionnary.GetValueOrDefault(3)!,
                _TournamentDictionnary.GetValueOrDefault(4)!
            },
            Capacity = 13000,
            Description = "A l’occasion de cet événement « Lyon Esport », vous remarquerez dans le tableau ci-dessus que seuls les deux premiers de chaque tournoi sont primés. Mais pour d’autres événements, l’organisateur peut décider de primer n’importe quel classement."
        };

        return Task.FromResult(eventa);
    }
}
