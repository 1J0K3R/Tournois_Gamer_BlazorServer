using Bunit;
using Microsoft.Extensions.DependencyInjection;

using Tournois_Gamer_BlazorServer.Data.Evenement.Interfaces;
using Tournois_Gamer_BlazorServer.Data.Evenement.Services;
using Tournois_Gamer_BlazorServer.Pages;

namespace Tournois_Gamer_BlazorServerTest.Bunit;

public class UnitTest1 : TestContext
{
    [Fact]
    public void findStringEsport()
    {
        Services.AddSingleton<IEventServices, EventServices>();

        var component = RenderComponent<LyonEsport>();

        component.Find("h5").MarkupMatches("<h5>EVENEMENT « Du 15 au 17 Septembre 2023 »</h5>");
    }

    [Fact]
    public void findEmptyStringMessageInscriptionIndividual()
    {
        Services.AddSingleton<IEventServices, EventServices>();

        var component = RenderComponent<InscriptionIndividual>();

        component.Find("button").Click();

        component.FindAll(".validation-errors");
        component.FindAll(".validation-message");
    }

    [Fact]
    public void findEmptyStringMessageInscriptionTeam()
    {
        Services.AddSingleton<IEventServices, EventServices>();

        var component = RenderComponent<InscriptionTeam>();

        component.Find("button").Click();

        component.FindAll(".validation-errors");
        component.FindAll(".validation-message");
    }
}