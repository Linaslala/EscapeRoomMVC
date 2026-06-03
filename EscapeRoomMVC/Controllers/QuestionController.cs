using EscapeRoomMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EscapeRoomMVC.Controllers
{
    public class QuestionController : Controller
    {
        public List<QuestionViewModel> Questions { get; set; } = new List<QuestionViewModel>();

        public IActionResult Index()
        {
            Questions.Add(new QuestionViewModel
            {
                Id = 1,
                Title = "Riddle one",
                Description = "Den har inget lock inte ingen botten, men kan ändå hålla kött, blod och ben på samma gång.",
                Answer = "Ringen"
            });

            Questions.Add(new QuestionViewModel
            {
                Id = 2,
                Title = "Riddle two",
                Description = "Gissar du mig har du gissat fel: gissar du fel har du i alla fall gissat rätt.",
                Answer = "Fel"
            });

            Questions.Add(new QuestionViewModel
            {
                Id = 3,
                Title = "Riddle three",
                Description = "Det simmade tio fiskar i en stängd tank. Två av dem sjönk till botten, fyra simmade iväg och tre dog. Hur många fanns kvar?",
                Answer = "Tio"
            });

            Questions.Add(new QuestionViewModel
            {
                Id = 4,
                Title = "Riddle four",
                Description = "Vad är det för farkost som läses likadant framifrån som bakifrån?",
                Answer = "Kajak"
            });

            Questions.Add(new QuestionViewModel
            {
                Id = 5,
                Title = "Riddle five",
                Description = "Två ingångar till huset, men först när man är ute med fötterna är man riktigt inne?",
                Answer = "Byxorna"
            });


            return View(Questions);
        }
    }
}
