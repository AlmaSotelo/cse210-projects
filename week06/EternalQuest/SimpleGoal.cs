using System.ComponentModel;
public class SimpleGoal :  Goal
{
   // Attributes
   public bool _isComplete;
   
   //Constructor that accepts, name, description and points. Get the values passed from the constractor in parent class. Sets the variable for if it is complete to be false.
   public SimpleGoal(string name, string description, string points) : base (name, description, points)
   {
      //_shortName = name;
      //_description = description;
      //_points = points;
      _isComplete = false;
   }

   public override void RecordEvent()
   {
      //If we previously were not complete, then mark complete and return poins
      if (_isComplete == false)
      {
         _isComplete = true;
         CongratsMessage(int.Parse(_points),0);
      }
      // what if we previously were complete?
      else
         Console.WriteLine("You already completed this goal! ");
      
   }
   //return whether this goal is complete or not
   public override bool IsComplete()
   {
      return _isComplete;
   }

   //prepare a string to be save to a text file
   public override string GetStringRepresentation()
   {
      return $"SimpleGoal: {_shortName}, {_description}, {_points}, {_isComplete}";
   }
            //setter for _isComplete
   public void SetIsComplete(string complete)
   {
      if (complete == "True")
      {
         _isComplete = true;
      }
      else
      {
         _isComplete = false;
      }
   }  
}