//class that inherit from the base Activity class
public class ListingActivity : Activity
{
   //variables
   int _count;
   List<string> _prompts;

   //contructor
   public ListingActivity()
   {
      _name = "Listing Activity";
      _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
      _prompts =
      [
         "Who are people that you appreciate?",
         "What are personal strengths of yours?",
         "Who are people that you have helped this week?",
         "When have you felt the Holy Ghost this month?",
         "Who are some of your personal heroes?"
      ];
   }

   //methods
   public void Run()
   {
      Console.WriteLine("List as many responses you can to the following prompt");
      GetRandomPrompt();
      Console.Write("You may begin in: ");
      ShowCountDown(5);
      DateTime startTime = DateTime.Now;
      //in order to access _duration, change it to protected
      DateTime futureTime = startTime.AddSeconds(_duration);
      do
      {
         GetListFromUser();
         _count++;
      } while (DateTime.Now < futureTime);
      Console.WriteLine($"You listed {_count} items");
   }

   public void GetRandomPrompt()
   {
      // Random object   
      Random promptPicker = new Random();
      // get random index
      int index = promptPicker.Next(_prompts.Count);
      //print random prompt
      Console.WriteLine($"--- {_prompts[index]} ---");
   }

   public List<string> GetListFromUser()
   {
      List<string> _listFromUser = new List<string>();
      Console.Write("\n>");
      string userEntry = Console.ReadLine();
      _listFromUser.Add(userEntry);

      return _listFromUser;
   }   
}