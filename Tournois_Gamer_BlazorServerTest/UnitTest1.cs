using Bunit;

using Microsoft.Win32;

using Tournois_Gamer_BlazorServer.Pages;

namespace Tournois_Gamer_BlazorServerTest;

public class UnitTest1 : TestContext
{
    [Fact]
    public void RegisterButtonThrowRequiredErrorWhenClicked()
    {
        var cut = RenderComponent<LyonEsport>();

        cut.Find("button").Click();
    }
}