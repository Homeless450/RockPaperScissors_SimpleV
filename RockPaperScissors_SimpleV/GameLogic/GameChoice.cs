using Newtonsoft.Json;
using RockPaperScissors_SimpleV.Models;

namespace RockPaperScissors_SimpleV.CurbServices
{
    public class GameChoice : IGameChoice
    {
        public async Task<GameChoiceModel> GameIsChoosing(IConfiguration configuration)
        {
            var client = new HttpClient();

            var baseAdress = configuration.GetSection("BaseAdress").Value;

            client.Timeout = TimeSpan.FromSeconds(5);
            var content = await client.GetStringAsync(baseAdress);
            var gameChoice = JsonConvert.DeserializeObject<GameChoiceModel>(content);
            
            if (gameChoice.StatusCode == 200)
            {
                gameChoice.WhosChoice = "Curb";
                return gameChoice;
            }
            else
            {
                gameChoice.Body = RandomChoice();
                gameChoice.WhosChoice = "local";
                return gameChoice;
            }
        }        

        private string RandomChoice()
        {
            Random rnd = new Random();

            string[] LocalChoice = new string[3] { "rock", "paper", "scissors" }; 
            var randomChoice = LocalChoice[rnd.Next(0, LocalChoice.Length)];
            return randomChoice;
        }
    }
}
