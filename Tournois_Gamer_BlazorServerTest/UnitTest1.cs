using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Tournois_Gamer_BlazorServer.Data.Evenement.Interfaces;
using Tournois_Gamer_BlazorServer.Data.Evenement.Models;
using Tournois_Gamer_BlazorServer.Data.Evenement.Services;
using Tournois_Gamer_BlazorServer.Pages;

namespace Tournois_Gamer_BlazorServerTest;

public class UnitTest1 : TestContext
{
    [Fact]
    public void findString()
    {
        Services.AddSingleton<IEventServices, EventServices>();
                
        var component = RenderComponent<LyonEsport>();

        component.Find("h5").MarkupMatches("<h5>EVENEMENT « Du 15 au 17 Septembre 2023 »</h5>");
    }

    [Fact]
    public void findEmptyStringMessage()
    {
        // Arrange
        var eventServicesMock = new Mock<IEventServices>();
        var expectedEvent = new EventDto
        {
            // Set the properties of the event object as needed for your test
        };
        eventServicesMock.Setup(s => s.GetEventAsync()).ReturnsAsync(expectedEvent);
        Services.AddSingleton<IEventServices>(eventServicesMock.Object);

        // Act
        var cut = RenderComponent<LyonEsport>();

        // Assert
        cut.Find("h5").MarkupMatches($"EVENEMENT « {expectedEvent.DatesString} »");
        // Add more assertions as needed for other elements in the page
    }

}
