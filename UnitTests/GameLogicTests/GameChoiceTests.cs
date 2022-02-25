using Microsoft.Extensions.Configuration;
using RockPaperScissors_SimpleV.CurbServices;
using System;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.GameLogicTests
{

    public class GameChoiceTests
    {
        [Fact]
        public async Task GameIsChoosing_RequestToAPI_GetSomeResponse()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            //arrange
            var gameChoice = new GameChoice();

            //act
            var output = await gameChoice.GameIsChoosing(configuration);

            //assert
            Assert.NotNull(output);
        }
    }
}
