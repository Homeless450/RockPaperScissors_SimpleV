using Newtonsoft.Json;
using RockPaperScissors_SimpleV.Models;

namespace RockPaperScissors_SimpleV.CurbServices
{
    public class GameChoice : IGameChoice
    {
        public async Task<GameChoiceModel> GameIsChoosing(IConfiguration configuration)
        {
            var client = new HttpClient();

            var baseAdress = configuration.GetSection("AppSettings").GetSection("BaseAdress").Value;

            client.Timeout = TimeSpan.FromSeconds(5);
            var content = await client.GetStringAsync(baseAdress);
            var gameChoice = JsonConvert.DeserializeObject<GameChoiceModel>(content);
            
            if (gameChoice.StatusCode == 200)
            {
                gameChoice.WhosChoice = "curb";
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

            string[] myArr = new string[3] { "rock", "paper", "scissors" }; 
            var randomChoice = myArr[rnd.Next(0, myArr.Length)];
            return randomChoice;
        }
    }
}
