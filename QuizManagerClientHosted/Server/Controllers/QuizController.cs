using Microsoft.AspNetCore.Mvc;
using QuizManagerClientHosted.Shared;

namespace QuizManagerClientHosted.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class QuizController : ControllerBase
{
    private static readonly List<QuizItem> Quiz = new List<QuizItem> {
    new QuizItem
      {
            Question = "Which of the following is the name of a Leonardo da Vinci's masterpiece?",
            Choices = new List<string> {"Sunflowers", "Mona Lisa", "The Kiss"},
            AnswerIndex = 1,
            Score = 3
      },
    new QuizItem
      {
            Question = "Which of the following novels was written by Miguel de Cervantes?",
            Choices = new List<string> {"The Ingenious Gentleman Don Quixote of La Mancia", "The Life of Gargantua and of Pantagruel", "One Hundred Years of Solitude"},
            AnswerIndex = 0,
            Score = 5
      },
    new QuizItem
        {
            Question = "What is the capital of France?",
            Choices = new List<string> {"Madrid", "Berlin", "Paris"},
            AnswerIndex = 2,
            Score = 4
        },
    new QuizItem
        {
            Question = "What is the symbol for the chemical element Oxygen?",
            Choices = new List<string> {"O", "Ox", "O2"},
            AnswerIndex = 0,
            Score = 2
        },
    new QuizItem
        {
            Question = "What is the symbol for the chemical element Oxygen?",
            Choices = new List<string> {"O", "Ox", "O2"},
            AnswerIndex = 0,
            Score = 2
        },
    new QuizItem
        {
            Question = "Which planet is known as the 'Red Planet'?",
            Choices = new List<string> {"Venus", "Mars", "Saturn"},
            AnswerIndex = 1,
            Score = 3
        },
    new QuizItem
        {
            Question = "Who wrote the play 'Romeo and Juliet'?",
            Choices = new List<string> {"William Shakespeare", "Oscar Wilde", "Jane Austen"},
            AnswerIndex = 0,
            Score = 4
        }
    };

    [HttpGet]
    public List<QuizItem> Get()
    {
        return Quiz;
    }
}
