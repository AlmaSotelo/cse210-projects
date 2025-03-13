public class Prompt

{
   //Get random element from Arrey. From bytehide.com
   string[] _prompts = 
   {
      "Who was the most interesting person I interacted with today?",
      "What was the best part of my day?",
      "How did I see the hand of the Lord in my life today?",
      "What was the strongest emotion I felt today?",
      "If I had one thing I could do over today, what would it be?",
      "what made you feel inspired today?",
      "I feel confident in  my ability to_____, why?",
      "What do you need to repent for today?",
      "How do you feel when you picture your children?",
      "whom would you like to serve tomorrow?",
      "What made you smile today?"
   }; 
   // A method that displays the random picked prompt, with no parameters and no return.
   public string promptPicker() 
   {
   // Random object   
   Random picker = new Random();

   // get random index
   int index = picker.Next(_prompts.Length);

   //print random prompt
   return _prompts[index];
   }
}  