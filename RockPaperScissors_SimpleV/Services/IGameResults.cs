namespace RockPaperScissors_SimpleV.Services
{
    public interface IGameResults
    {
        public GameResultModel PlayerChoice(string playerChoice, string gameChoice);
    }
}
