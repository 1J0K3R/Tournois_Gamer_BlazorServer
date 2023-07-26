using Tournois_Gamer_BlazorServer.Data.Evenement.Models;

namespace Tournois_Gamer_BlazorServer.Data.Evenement.Interfaces
{
    public interface IEventServices
    {
        public Task<EventDto> GetEventAsync();
    }
}
