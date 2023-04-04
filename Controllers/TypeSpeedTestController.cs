using Microsoft.AspNetCore.Mvc;
using TypeTest.Models;

namespace TypeTest.Controllers
{
    public class TypeSpeedTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Test()
        {
            Speed speedobj = new Speed();
            int rng = new Random().Next(speedobj.SentencesToType.Length);
            string TexttoType = speedobj.SentencesToType[rng];

            speedobj.TextToType = TexttoType;

            return View(speedobj);
        }

        [HttpPost]
        public IActionResult Test(string sentenceByUser, string textToType, DateTime startTime, int totalCharactersTyped, int correctlyTypedCharacters)
        {
            if (string.IsNullOrEmpty(sentenceByUser) || string.IsNullOrEmpty(textToType))
            {
                //bug here
                return RedirectToAction("Test");
            }

            var speedobj = new Speed();
            var timeTakenInSeconds = (int)(DateTime.Now - startTime).TotalSeconds;
            var wordsTyped = sentenceByUser.Split(' ').Length;
            var wordsPerMinute = (int)(wordsTyped / ((double)timeTakenInSeconds / 60));
           
            //check here
            for (int i = 0; i < sentenceByUser.Length && i < textToType.Length; i++)
            {
                if (sentenceByUser[i] == textToType[i])
                {
                    correctlyTypedCharacters++;
                }
            }
           
            speedobj.TextToType = textToType;
            speedobj.SentenceByUser = sentenceByUser;
            speedobj.WordsPerMinute = wordsPerMinute;
            speedobj.TotalCharactersTyped = sentenceByUser.Length;
            speedobj.CorrectlyTypedCharacters = correctlyTypedCharacters;
           

            if (sentenceByUser == textToType)
            {
                speedobj.Status = true;
                speedobj.TotalCharactersTyped = sentenceByUser.Length;
                speedobj.CorrectlyTypedCharacters = sentenceByUser.Length;
            }
            else
            {
                speedobj.Status = false;
            }

            return View("Results", speedobj);
        }


    }
}