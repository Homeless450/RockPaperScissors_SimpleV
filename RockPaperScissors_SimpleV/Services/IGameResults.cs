using RockPaperScissors_SimpleV.Models;

namespace RockPaperScissors_SimpleV.Services
{
    public interface IGameResults
    {
        public GameResultModel ShowGameResult(string playerChoice, GameChoiceModel gameChoice);
    }
}
