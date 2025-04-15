using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
public abstract class Goal
{
            //Atributes
   protected string _shortName;
   protected string _description;
   protected string _points;
   private int totalPoints; 
            //Constructors 
   //Contructor to initialize variables with default values
   public Goal()
   {
      _shortName = "Test Goal Name";
      _description = "Test Goal Description";
      _points = "50";     
   }
   //Constructor accepting name, description, and points
   public Goal(string name, string description, string points)
   {
      _shortName = name;
      _description = description;
      _points = points;
   }
   
            //methods
   //RecordEvent, ISCompplete, and GetStringRepresentation are abstract because they will be implemented differently inside all child classes
   public abstract void RecordEvent();
   public abstract bool IsComplete();
   //provides all of the details of a goal in a way that is easy to save to a file, and then load later
   public abstract string GetStringRepresentation();

   //method to export the  total points
   public int GetPoints()
   {
      return totalPoints;
   }   
   
   //Returns the details of a goal that could be shown in a list. It includes checkbox, short name, and description. This method will be override in the ChecklistGoal to also show the number of time the goal has been accomplished so far. Make it virtual so can be overrideble
   public virtual string GetDetailsString()
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
      string outputString = $"{checkbox} {_shortName} ({_description})";
      return outputString;
   }

   public virtual string GetGoalName()
   {      
      return $"{_shortName}";
   }

   //method to display the contrats message and total points
   public void CongratsMessage(int points, int bonus)
   {
      Console.WriteLine($"Congratulatios! You have earned {points} points");
      if (bonus > 0)
      {         
         Console.WriteLine($"You now have {points + bonus} points.");

      }
      totalPoints = points + bonus;
   }      
}