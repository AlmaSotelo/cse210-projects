//class that inherit from the base Activity class
public class ReflectingActivity : Activity
{
   //variables
   private List<string> _prompts;
   private List<string> _questions;
   
   //Create a constructor for your class that has not parameters
   public ReflectingActivity()
   {
      //make sure variables are accessible by having them protected 
      _name = "Reflecting Activity";
      _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
      _prompts =
      [
         "Think of a time when you stood up for someone else.",
         "Think of a time when you did something really difficult.",
         "Think of a time when you helped someone in need.",
         "Think of a time when you did something truly selfless."
      ];
      _questions =
      [
         "Why was this experience meaningful to you?",
         "Have you ever done anything like this before?",
         "How did you get started?",
         "How did you feel when it was complete?",
         "What made this time different than other times when you were not as successful?",
         "What is your favorite thing about this experience?",
         "What could you learn from this experience that applies to other situations?",
         "What did you learn about yourself through this experience?",
         "How can you keep this experience in mind in the future?"
      ];

   }
   //method to run the activity itself
   public void Run()
   {
      Console.WriteLine("Consider the following prompt:");
      Console.WriteLine(DisplayPrompt());
      Console.WriteLine("When you have something in mind, press enter to continue");
      string input = Console.ReadLine();
      
      if (input == "")
      {
         Console.WriteLine("Now ponder on each of the following quesions as they related to this experience.");
         Console.Write("You may begin in: ");
         ShowCountDown(9);
         Console.Clear();
         DateTime startTime = DateTime.Now;
         //in order to access _duration, change it to protected
         DateTime futureTime = startTime.AddSeconds(_duration);
         do
         { 
            Console.Write($"\n{DisplayQuestion()}");
            ShowSpinner(5);
         }while (DateTime.Now < futureTime);         
         Console.WriteLine();
      }   
   }
   // A method that displays the random picked prompt, with no parameters, and returning a prompt.
   public string GetRandomPrompt()
   {
      // Random object   
      Random promptPicker = new Random();
      // get random index
      int index = promptPicker.Next(_prompts.Count);
      //print random prompt
      return _prompts[index];
   }
   // A method that generates a random question, with no parameters, and returning a question.
   public string GetRandomQuestion()
   {
      // Random object   
      Random questionPicker = new Random();
      // get random index
      int index = questionPicker.Next(_questions.Count);
      //print random prompt
      return _questions[index];
   }
   //A method that displays the picked prompt
   public string DisplayPrompt()
   {
      string aPrompt = GetRandomPrompt();
      return $"--- {aPrompt} ---";
   }

   //A method that displays the picked question
   public string DisplayQuestion()
   {
      string aQuestion = GetRandomQuestion();
      return $"> {aQuestion}";
   }

}        