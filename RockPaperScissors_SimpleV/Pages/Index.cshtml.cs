using Microsoft.AspNetCore.Mvc.RazorPages;
using RockPaperScissors_SimpleV.Models;
using RockPaperScissors_SimpleV.Services;
using RockPaperScissors_SimpleV.CurbServices;

namespace RockPaperScissors_SimpleV.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<GameChoiceModel> UserChoice { get; set; }
        IConfiguration _configuration;
        IGameResults _gameResults;
        IGameChoice _gameChoice;

        public IndexModel(IConfiguration configuration, IGameResults gameResults, IGameChoice gameChoice)
        {
            _configuration = configuration;
            _gameResults = gameResults;
            _gameChoice = gameChoice;
        }

        
        public async void OnPostRockAsync()
        {
            var gameChoice1 = await _gameChoice.GameIsChoosing(_configuration);
            _gameResults.ShowGameResult("rock", gameChoice1);
        }

        public async void OnPostPaperAsync()
        {
            var gameChoice1 = await _gameChoice.GameIsChoosing(_configuration);
            _gameResults.ShowGameResult("paper", gameChoice1);
        }

        public async void OnPostScissorsAsync()
        {
            var gameChoice1 = await _gameChoice.GameIsChoosing(_configuration);
            _gameResults.ShowGameResult("scissors", gameChoice1);
        }
    }
}