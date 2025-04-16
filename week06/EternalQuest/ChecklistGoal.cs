using System.ComponentModel;
public class ChecklistGoal : Goal
{
   private int _amountCompleted;
   private int _target;
   private int _bonus;

   public ChecklistGoal(string name, string description, string points, int bonus, int target) : base (name, description, points)
   {
      _target = target;
      _bonus = bonus;
      _amountCompleted = 0;     
   }

         //methods
   //asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal      
   public override void RecordEvent ()    
   {
      _amountCompleted +=1;
      if (_amountCompleted == _target)
      {
         CongratsMessage(int.Parse(_points), _bonus);
      }
      else
      {
         CongratsMessage(int.Parse(_points), 0);
      }
   }
   //return whether this goal is complete or not
   public override bool IsComplete()
   {
      if (_amountCompleted >= _target) 
      {
         return true;
      }
      else 
         return false;
   }
   //shows the number of times the goal has been accomplished so far
   public override string GetDetailsString()
   {
      string checkbox;
      if (IsComplete())
      {
         checkbox = "[X]";
      }
      else
      {
         checkbox = "[ ]";
      }
      string outputString = $"{checkbox} {_shortName} ({_description}) -- Currently completed: ({_amountCompleted} / {_target})";
      
      return outputString;

   }
   public override string GetStringRepresentation()
   {
      return $"ChecklistGoal: {_shortName}, {_description}, {_points}, {_bonus}, {_target}, {_amountCompleted}";
   }

            //setter for _amountCompleted
   public void SetAmountCompleted(int complete)
   {
      _amountCompleted = complete;
   }              
}