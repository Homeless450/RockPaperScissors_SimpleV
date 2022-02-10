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
        public string Message { get; set; }

        public IndexModel(IConfiguration configuration, IGameResults gameResults, IGameChoice gameChoice)
        {
            _configuration = configuration;
            _gameResults = gameResults;
            _gameChoice = gameChoice;
        }

        
        public async void OnPostRockAsync()
        {
            var botChoice = await _gameChoice.GameIsChoosing(_configuration);
            var message = _gameResults.ShowGameResult("rock", botChoice);

            Message = $"{ message}";
        }

        public async void OnPostPaperAsync()
        {
            var botChoice = await _gameChoice.GameIsChoosing(_configuration);
            var message = _gameResults.ShowGameResult("paper", botChoice);

            Message = $"{ message}";
        }

        public async void OnPostScissorsAsync()
        {
            var botChoice = await _gameChoice.GameIsChoosing(_configuration);
            var message = _gameResults.ShowGameResult("scissors", botChoice);

            Message = $"{ message}";
        }
    }
}