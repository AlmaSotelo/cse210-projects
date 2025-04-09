//class that inherit from the base Activity class
public class BreathingActivity : Activity
{
   //Create a constructor for your class has no parameters
   public BreathingActivity()
   {
      //make sure variables are accessible by changing to protected 
      _name = "Breading Activity";
      _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
   }

   //method to run the activity itself
   public void Run()
   {
      DateTime startTime = DateTime.Now;
      //in order to access _duration, change it to protected
      DateTime futureTime = startTime.AddSeconds(_duration);
      do
      {
         Console.Write("\nBreathe in...");
         ShowCountDown(3);
         Console.Write("\nNow breathe out...");
         ShowCountDown(4);
         Console.WriteLine();
      }
      while (DateTime.Now < futureTime);      
   }
}