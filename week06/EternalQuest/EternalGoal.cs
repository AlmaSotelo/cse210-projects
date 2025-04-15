using System.ComponentModel;
public class EternalGoal : Goal
{
         //no variables
   
         //constructor accepting name, description, and points
   public EternalGoal(string name, string description, string points) : base (name, description, points)
   {

   }

         //methods
   public override void RecordEvent()
   {
      CongratsMessage(int.Parse(_points),0);
   } 
   //this goal never is completed
   public override bool IsComplete()
   {
      return false;
   }
   public override string GetStringRepresentation()
   {
      return $"EternalGoal: {_shortName}, {_description}, {_points}";
   }

}