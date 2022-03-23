using RockPaperScissors_SimpleV.Models;

namespace RockPaperScissors_SimpleV.Services
{
    public interface IGameResults
    {
        public string ShowGameResult(string playerChoice, GameChoiceModel gameChoice);
    }
}
