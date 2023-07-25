using Tournois_Gamer_BlazorServer.Data.Evenement.Models;

namespace Tournois_Gamer_BlazorServer.Data.Evenement.Services;

public class EventServices
{
    private Dictionary<int, TournamentTypeDto> _TournamentNameDictionnary { get; set; } = new();
    private Dictionary<int, TournamentDto> _TournamentDictionnary { get; set; } = new();
    private Dictionary<int, TournamentTypeDto> GetTournamentNameDictionnary()
    {
        Dictionary<int, TournamentTypeDto> tournaments = new()
        {
            {
                0,
                new TournamentTypeDto()
                {
                    Id = 0,
                    Name = "League Of Legends"
                }
            },
            {
                1,
                new TournamentTypeDto (){
                    Id = 1,
                    Name = "FIFA par équipe"
                }
            },
            {
                2,
                new TournamentTypeDto (){
                    Id = 2,
                    Name = "FIFA individuel"
                }
            }
        };

        return tournaments;
    }
    private Dictionary<int, TournamentDto> GetEngagementDictionnary()
    {
        Dictionary<int, TournamentDto> engagementTerms = new()
        {
            {
                0,
                new TournamentDto()
                {
                    Id = 0,
                    //TournamentName = _TournamentNameDictionnary.GetValueOrDefault(0)!,
                    IsTeam = true,
                    TeamNbr = 32,
                    PlayerNbrPerTeam = 5,
                    Platform = "PC",
                    CostEntry = 100,
                    CashPrize = new CashPrizeDto()
                    {
                        Id = 0,
                        WinnersPrice = 5000,
                        FinalistPrice = 2000
                    }
                }
            },{
                1,
                new TournamentDto()
                {
                    Id = 1,
                    //TournamentName = _TournamentNameDictionnary.GetValueOrDefault(1)!,
                    IsTeam = true,
                    TeamNbr = 64,
                    PlayerNbrPerTeam = 2,
                    Platform = "PS5",
                    CostEntry = 30,
                    CashPrize = new CashPrizeDto()
                    {
                        Id = 1,
                        WinnersPrice = 3000,
                        FinalistPrice = 1500
                    }
                }
            },
            {
                2,
                new TournamentDto()
                {
                    Id = 2,
                    //TournamentName = _TournamentNameDictionnary.GetValueOrDefault(1)!,
                    IsTeam = true,
                    TeamNbr = 64,
                    PlayerNbrPerTeam = 2,
                    Platform = "XBOX",
                    CostEntry = 30,
                    CashPrize = new CashPrizeDto()
                    {
                        Id = 2,
                        WinnersPrice = 3000,
                        FinalistPrice = 1500
                    }
                }
            },

            {
                3,
                new TournamentDto()
                {
                    Id = 3,
                    //TournamentName = _TournamentNameDictionnary.GetValueOrDefault(2)!,
                    IsTeam = false,
                    TeamNbr = 128,
                    PlayerNbrPerTeam = 1,
                    Platform = "PS5",
                    CostEntry = 15,
                    CashPrize = new CashPrizeDto()
                    {
                        Id = 3,
                        WinnersPrice = 2000,
                        FinalistPrice = 1000
                    }
                }
            },
            {
                4,
                new TournamentDto()
                {
                    Id = 4,
                    //TournamentName = _TournamentNameDictionnary.GetValueOrDefault(2)!,
                    IsTeam = false,
                    TeamNbr = 128,
                    PlayerNbrPerTeam = 1,
                    Platform = "XBOX",
                    CostEntry = 15,
                    CashPrize = new CashPrizeDto()
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
    public Task<EventDto> GetEventAsync()
    {
        _TournamentNameDictionnary = GetTournamentNameDictionnary();
        _TournamentDictionnary = GetEngagementDictionnary();

        EventDto eventa = new()
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
            TournamentNameList = new List<TournamentTypeDto> {
                _TournamentNameDictionnary.GetValueOrDefault(0)!,
                _TournamentNameDictionnary.GetValueOrDefault(1)!,
                _TournamentNameDictionnary.GetValueOrDefault(2)!,
            },
            TournamentList = new List<TournamentDto>{
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
