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
            var inputData = new GameChoiceModel() { WhosChoice = "Curb", StatusCode = 200, Body = "rock" };

            //act
            var outputSting = gameResults.ShowGameResult("rock", inputData);

            //assert
            Assert.Equal(expectedOutputString, outputSting);
        }

        [Fact]
        public void ShowGameResults_RockbyPlayerPaperByCurb_CurbWon()
        {
            //arrange
            var gameResults = new GameResults();

            var expectedOutputString = "Curb won with paper. Player lost with rock.";
            var inputData = new GameChoiceModel() { WhosChoice = "Curb", StatusCode = 200, Body = "paper" };

            //act
            var outputSting = gameResults.ShowGameResult("rock", inputData);

            //assert
            Assert.Equal(expectedOutputString, outputSting);
        }

        [Fact]
        public void ShowGameResults_RockbyPlayerScissorsByCurb_PlayerWon()
        {
            //arrange
            var gameResults = new GameResults();

            var expectedOutputString = "Player won with rock. Curb lost with scissors.";
            var inputData = new GameChoiceModel() { WhosChoice = "Curb", StatusCode = 200, Body = "scissors" };

            //act
            var outputSting = gameResults.ShowGameResult("rock", inputData);

            //assert
            Assert.Equal(expectedOutputString, outputSting);
        }

        [Fact]
        public void ShowGameResults_ScissorsByPlayerScissorsByCurb_DrawResult()
        {
            //arrange
            var gameResults = new GameResults();

            var expectedOutputString = "It's a draw";
            var inputData = new GameChoiceModel() { WhosChoice = "Curb", StatusCode = 200, Body = "scissors" };

            //act
            var outputSting = gameResults.ShowGameResult("scissors", inputData);

            //assert
            Assert.Equal(expectedOutputString, outputSting);
        }

        [Fact]
        public void ShowGameResults_ScissorsbyPlayerRockByCurb_CurbWon()
        {
            //arrange
            var gameResults = new GameResults();

            var expectedOutputString = "Curb won with rock. Player lost with scissors.";
            var inputData = new GameChoiceModel() { WhosChoice = "Curb", StatusCode = 200, Body = "rock" };

            //act
            var outputSting = gameResults.ShowGameResult("scissors", inputData);

            //assert
            Assert.Equal(expectedOutputString, outputSting);
        }

        [Fact]
        public void ShowGameResults_PaperWasChoosedByBoth_DrawResult()
        {
            //arrange
            var gameResults = new GameResults();

            var expectedOutputString = "It's a draw";
            var inputData = new GameChoiceModel() { WhosChoice = "Curb", StatusCode = 200, Body = "paper" };

            //act
            var outputSting = gameResults.ShowGameResult("paper", inputData);

            //assert
            Assert.Equal(expectedOutputString, outputSting);
        }

        [Fact]
        public void ShowGameResults_PaperbyPlayerScissorsByCurb_CurbWon()
        {
            //arrange
            var gameResults = new GameResults();

            var expectedOutputString = "Curb won with scissors. Player lost with paper.";
            var inputData = new GameChoiceModel() { WhosChoice = "Curb", StatusCode = 200, Body = "scissors" };

            //act
            var outputSting = gameResults.ShowGameResult("paper", inputData);

            //assert
            Assert.Equal(expectedOutputString, outputSting);
        }
        [Fact]
        public void ShowGameResults_PaperbyPlayerRockByCurb_PlayerWon()
        {
            //arrange
            var gameResults = new GameResults();

            var expectedOutputString = "Player won with paper. Curb lost with rock.";
            var inputData = new GameChoiceModel() { WhosChoice = "Curb", StatusCode = 200, Body = "rock" };

            //act
            var outputSting = gameResults.ShowGameResult("paper", inputData);

            //assert
            Assert.Equal(expectedOutputString, outputSting);
        }

        [Fact]
        public void ShowGameResults_ScissorsbyPlayerPaperByCurb_PlayerWon()
        {
            //arrange
            var gameResults = new GameResults();

            var expectedOutputString = "Player won with scissors. Curb lost with paper.";
            var inputData = new GameChoiceModel() { WhosChoice = "Curb", StatusCode = 200, Body = "paper" };

            //act
            var outputSting = gameResults.ShowGameResult("scissors", inputData);

            //assert
            Assert.Equal(expectedOutputString, outputSting);
        }
    }
}

