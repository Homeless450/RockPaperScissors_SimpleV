using Microsoft.AspNetCore.Mvc.RazorPages;
using RockPaperScissors_SimpleV.Services;
using RockPaperScissors_SimpleV.CurbServices;
using RockPaperScissors_SimpleV.Models;

namespace RockPaperScissors_SimpleV.Pages
{
    public class IndexModel : PageModel
    {
        IConfiguration _configuration;
        IGameResults _gameResults;
        IGameChoice _gameChoice;
        public string Message { get; set; } = "1";

        public IndexModel(IConfiguration configuration, IGameResults gameResults, IGameChoice gameChoice)
        {
            _configuration = configuration;
            _gameResults = gameResults;
            _gameChoice = gameChoice;
        }
        
        public async Task OnPostRockAsync()
        {
            var botChoice = await _gameChoice.GameIsChoosing(_configuration);
            //var botChoice = new GameChoiceModel() { Body = "rock", StatusCode=200, WhosChoice="curb"};
            var message = _gameResults.ShowGameResult("rock", botChoice);

            Message = $"{ message} ";
        }

        public async Task OnPostPaperAsync()
        {
            var botChoice = await _gameChoice.GameIsChoosing(_configuration);
            var message = _gameResults.ShowGameResult("paper", botChoice);

            Message = $"{ message}";
        }

        public async Task OnPostScissorsAsync()
        {
            var botChoice = await _gameChoice.GameIsChoosing(_configuration);
            var message = _gameResults.ShowGameResult("scissors", botChoice);

            Message = $"{ message}";
        }
    }
}