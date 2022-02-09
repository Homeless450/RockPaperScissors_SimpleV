using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RockPaperScissors_SimpleV.Models;
using System.Collections.Generic;

namespace RockPaperScissors_SimpleV.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<ChoiceModel> UserChoice { get; set; }

        public IndexModel()
        {
        }

        public void OnGet()
        {

        }
    }
}