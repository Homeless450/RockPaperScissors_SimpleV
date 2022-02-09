using RockPaperScissors_SimpleV.Models;

namespace RockPaperScissors_SimpleV.CurbServices
{
    public interface IGameChoice
    {
        public Task<GameChoiceModel> CurbChoice(IConfiguration configuration);
    }
}
