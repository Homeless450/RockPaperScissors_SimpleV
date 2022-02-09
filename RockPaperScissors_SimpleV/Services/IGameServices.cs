using RockPaperScissors_SimpleV.Models;

namespace RockPaperScissors_SimpleV.CurbServices
{
    public interface IGameServices
    {
        public Task<string> CurbChoice(IConfiguration configuration);
    }
}
