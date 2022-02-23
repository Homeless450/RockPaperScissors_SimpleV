using RockPaperScissors_SimpleV.Models;
using RockPaperScissors_SimpleV.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.GameLogicTests
{
    public class GameResultTests
    {
        [Fact]
        public void ShowGameResults_RockWasChoosedByBoth_DrawResult()
        {
            //arrange
            var gameResults = new GameResults();

            var expectedOutputString = "It's a draw";
            var inputData = new GameChoiceModel() { WhosChoice = "Curb", StatusCode = 200, Body = "rock"};

            //act
            var outputSting = gameResults.ShowGameResult("rock", inputData);

            //assert
            Assert.Equal(expectedOutputString, outputSting);
        }
    }
}

