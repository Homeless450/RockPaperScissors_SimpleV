using Microsoft.Extensions.Configuration;
using RockPaperScissors_SimpleV.CurbServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.GameLogicTests
{

    public class GameChoiceTests
    {


        [Fact]
        public async Task GameIsChoosing_RequestToAPI_GetSomeResponse()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

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
