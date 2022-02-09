using Newtonsoft.Json;
using RockPaperScissors_SimpleV.Models;

namespace RockPaperScissors_SimpleV.CurbServices
{
    public class GameServices : IGameServices
    {
        public async Task<string> CurbChoice(IConfiguration configuration)
        {
            var client = new HttpClient();

            var baseAdress = configuration.GetSection("AppSettings").GetSection("BaseAdress").Value;

            client.Timeout = TimeSpan.FromSeconds(5);
            var content = await client.GetStringAsync(baseAdress);
            var curbChoice = JsonConvert.DeserializeObject<ChoiceModel>(content);
            
            if (curbChoice.statusCode == 200)
            {
                return curbChoice.body;
            }
            else
            {
                return RandomChoice();
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
