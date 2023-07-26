using Tournois_Gamer_BlazorServer.Data.Evenement.Models;
using Tournois_Gamer_BlazorServer.Pages;

namespace Tournois_Gamer_BlazorServerTest.UnitTest
{
    public class LyonEsportTest
    {
        #region Test GetCashPrize
        [Fact]
        public void GetCashPrize_ReturnsCorrectString()
        {
            // Arrange
            var cashPrizeDto = new CashPrizeDto
            {
                WinnersPrice = 1000,
                FinalistPrice = 500
            };

            var expectedString = "Vainqueur : 1000 €" + Environment.NewLine + "Finaliste : 500 €";

            LyonEsport lyonEsport = new();
            // Act
            var result = lyonEsport.GetCashPrize(cashPrizeDto);

            // Assert
            Assert.Equal(expectedString, result);
        }

        [Fact]
        public void GetCashPrize_WithZeroValues_ReturnsCorrectString()
        {
            // Arrange
            var cashPrizeDto = new CashPrizeDto
            {
                WinnersPrice = 0,
                FinalistPrice = 0
            };

            var expectedString = "Vainqueur : 0 €" + Environment.NewLine + "Finaliste : 0 €";
            
            LyonEsport lyonEsport = new();
            // Act
            var result = lyonEsport.GetCashPrize(cashPrizeDto);

            // Assert
            Assert.Equal(expectedString, result);
        }

        [Fact]
        public void GetCashPrize_WithNegativeValues_ReturnsCorrectString()
        {
            // Arrange
            var cashPrizeDto = new CashPrizeDto
            {
                WinnersPrice = -100,
                FinalistPrice = -50
            };

            var expectedString = "Vainqueur : -100 €" + Environment.NewLine + "Finaliste : -50 €";

            LyonEsport lyonEsport = new();
            // Act
            var result = lyonEsport.GetCashPrize(cashPrizeDto);

            // Assert
            Assert.Equal(expectedString, result);
        }
        #endregion


        #region test 
        [Theory]
        [InlineData("League Of Legends", "PC", "League Of Legends")]
        [InlineData("FIFA par équipe", "PC", "FIFA par équipe")]
        [InlineData("FIFA individuel", "PC", "FIFA individuel")]
        public void GetTournamentPlatform_WithPcPlatform_ReturnsTournamentName(string tournamentName, string platform, string expected)
        {
            LyonEsport lyonEsport = new();
            // Act
            var result = lyonEsport.GetTournamentPlatform(tournamentName, platform);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("League Of Legends", "Xbox", "League Of Legends Xbox")]
        [InlineData("FIFA par équipe", "Xbox", "FIFA par équipe Xbox")]
        [InlineData("FIFA individuel", "Xbox", "FIFA individuel Xbox")]
        public void GetTournamentPlatform_WithXboxPlatform_ReturnsTournamentNameWithPlatform(string tournamentName, string platform, string expected)
        {
            LyonEsport lyonEsport = new();
            // Act
            var result = lyonEsport.GetTournamentPlatform(tournamentName, platform);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("League Of Legends", "PS5", "League Of Legends PS5")]
        [InlineData("FIFA par équipe", "PS5", "FIFA par équipe PS5")]
        [InlineData("FIFA individuel", "PS5", "FIFA individuel PS5")]
        public void GetTournamentPlatform_WithPs5Platform_ReturnsTournamentNameWithPlatform(string tournamentName, string platform, string expected)
        {
            LyonEsport lyonEsport = new();
            // Act
            var result = lyonEsport.GetTournamentPlatform(tournamentName, platform);

            // Assert
            Assert.Equal(expected, result);
        }
        #endregion
    }
}
