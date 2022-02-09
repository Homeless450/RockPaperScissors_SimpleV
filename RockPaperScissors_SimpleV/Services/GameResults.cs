using RockPaperScissors_SimpleV.Models;

namespace RockPaperScissors_SimpleV.Services
{
    public class GameResults
    {
        public GameResultModel ShowGameResult(string playerChoice, GameChoiceModel gameChoice)
        {
            var gameResult = new GameResultModel();

            gameResult.GameChoice = gameChoice.Body;
            gameResult.PlayerChoice = playerChoice;
            gameResult.WhosChoice = gameChoice.WhosChoice;
            gameResult.WhosWinner = WinnerDefinitan(playerChoice, gameChoice.Body, gameResult.WhosChoice);

            return gameResult;
        }

        private string WinnerDefinitan(string playerChoice, string gameChoice, string whosChoice)
        {
            if (playerChoice == "rock" && gameChoice == "scissors")
            {
                return "Player";
            }
            else if (playerChoice == "rock" && gameChoice == "paper")
            {
                return whosChoice;
            }
            else if (playerChoice == "paper" && gameChoice == "rock")
            {
                return "Player";
            }
            else if (playerChoice == "paper" && gameChoice == "scissors")
            {
                return whosChoice;
            }
            else if (playerChoice == "scissors" && gameChoice == "rock")
            {
                return whosChoice;
            }
            else if (playerChoice == "scissors" && gameChoice == "paper")
            {
                return "Player";
            }
            else
            {
                Console.WriteLine("Draw");
            };
            return null;
        }
    }
}
