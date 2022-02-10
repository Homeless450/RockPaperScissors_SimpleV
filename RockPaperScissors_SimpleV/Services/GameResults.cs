using RockPaperScissors_SimpleV.Models;

namespace RockPaperScissors_SimpleV.Services
{
    public class GameResults:IGameResults
    {

        public string ShowGameResult(string playerChoice, GameChoiceModel gameChoice)
        {
            var gameResult = new GameResultModel();

            gameResult.GameChoice = gameChoice.Body;
            gameResult.PlayerChoice = playerChoice;
            gameResult.WhosChoice = gameChoice.WhosChoice;
            gameResult.WhosWinner = WinnerDefinitan(playerChoice, gameChoice.Body, gameResult.WhosChoice);

            var message = EndGameMessageBuider(gameResult);
            return message;
        }

        private string EndGameMessageBuider(GameResultModel gameResult)
        {
            if (gameResult.WhosWinner == "Draw")
            {
                return "It's a draw";
            }
            else if (gameResult.WhosWinner == "Player")
            {
                return gameResult.WhosWinner + "won with" + gameResult.PlayerChoice + ". " + gameResult.WhosChoice + " lost with " + gameResult.GameChoice + ".";
            }
            else
            {
                return gameResult.WhosWinner + "won with" + gameResult.GameChoice + ". Player lost with " + gameResult.PlayerChoice + ".";
            }
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
                return "Draw";
            };
        }
    }
}
