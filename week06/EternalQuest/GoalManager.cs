using System.ComponentModel;
using System.Text;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
   //Attributes
   private List<Goal> _goals = new List<Goal>();
   private int _score;

   private string userFirstOption = "";
   private string userGoalOption = "";

   private SimpleGoal simpleGoal;
   private EternalGoal eternalGoal;
   private ChecklistGoal checklistGoal;

   //constructor inizializing the attributes
   public GoalManager()
   {
      _goals.Clear();
      _score = 0;
   }
   //methods
   //Displays the main menu and player info
   //Call:
   //CreateGoal, ListGoalDetails, SaveGoals, LoadGoals, RecordEvent
   //Loop until user quits
   public void Start()
   {
      
      while (userFirstOption != "6")
      {
         DisplayPlayerInfo();
         Console.WriteLine("Menu Options:");
         Console.WriteLine("  1. Create New Goal");
         Console.WriteLine("  2. List Goals");
         Console.WriteLine("  3. Save Goals");
         Console.WriteLine("  4. Load Goals");
         Console.WriteLine("  5. Record Goals");
         Console.WriteLine("  6. Quit");
         Console.Write("Select a choice from the menu: ");
         userFirstOption = Console.ReadLine();
         switch (userFirstOption)
         {
            case "1":
               CreateGoal();
               //simpleGoal.GetGoalName();
               break;
            case "2":
               ListGoalDetails();
               break;
            case "3":
               SaveGoals();
               break;
            case "4":
               LoadGoals();
               break;
            case "5":
               RecordEvent();
               break;
            case "6":
               Console.WriteLine("Bye now");
               break;
         }
      }
   }

   //Display the points
   public void DisplayPlayerInfo()
   {
      Console.WriteLine($"\nYou have {_score} points");
   }
   //Loop through the list of goals and display the names. MAY NEED ANOTHER METHOD IN THE GOAL CLASS!
   //1. Go to bed on time
   //2. Do my homework
   // ....  
   public void ListGoalNames()
   {
      int i = 1;
      foreach (Goal goal in _goals)
      {
         string goalNames = goal.GetGoalName();
         Console.WriteLine($"{i.ToString()}. {goalNames}");
         i++;
      }
   }
   //Loop through the list of goals and display the full details. MAY NEED ANOTHER METHOD IN GOAL CLASS!   
   public void ListGoalDetails()
   {
      int i = 1;
      Console.WriteLine("Your goals:");
      foreach (Goal goal in _goals)
      {
         string goalDetails = goal.GetDetailsString();
         Console.WriteLine($"{i.ToString()}. {goalDetails}");
         i++;
      }
   }
   //Display a sub-menu to select a goal type.
   //Ask for the name, description, and points
   //Ask for more if they pick checklist goal
   //Create the objects and add to the goal list
   public void CreateGoal()
   {
      Console.WriteLine("\nThe types of Goals are:");
      Console.WriteLine("  1. Simple Goal");
      Console.WriteLine("  2. Eternal Goal");
      Console.WriteLine("  3. Checklist Goal");
      Console.Write("Which type of goal would you like to create? ");
      userGoalOption = Console.ReadLine();
      Console.Write("What is the name of your goal? ");
      string _shortName = Console.ReadLine();
      Console.Write("What is a short description of it? ");
      string _description = Console.ReadLine();
      Console.Write("What is the amount of points associated with this goal? ");
      string _points = Console.ReadLine();

      switch (userGoalOption)
      {
         case "1":
            simpleGoal = new SimpleGoal(_shortName, _description, _points);
            _goals.Add(simpleGoal);
            break;
         case "2":
            eternalGoal = new EternalGoal(_shortName, _description, _points);
            _goals.Add(eternalGoal);
            break;
         case "3":
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int _target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int _bonus = int.Parse(Console.ReadLine());
            checklistGoal = new ChecklistGoal(_shortName, _description, _points, _target, _bonus);
            _goals.Add(checklistGoal);
            break;
      }
   }
   //Display a list of all of the goal names
   //Ask user to select a goal
   //Call RecordEvent on the correct goal
   //Update the score based on the points
   //Display current points
   public void RecordEvent()
   {
      int numberGoal;
      ListGoalNames();
      Console.Write("Which goal did you accomplish? ");
      numberGoal = int.Parse(Console.ReadLine());
      //get the correct index of the goal
      _goals[numberGoal - 1].RecordEvent();
      _score += _goals[numberGoal - 1].GetPoints();
   }
   //Ask user for a file name
   //Look through the goals, and convert each goal to a string and then save the string
   public void SaveGoals()
   {
      Console.Write("Waht is the filename for the goal file? ");
      string filename = Console.ReadLine();
      string path = @"C:\Users\Alma\Documents\BYU-Pathway\SOFTWARE DEVELOPMENT Degree\Associate Degree All Courses\WEB And COMPUTER PROGRAMMING  Certificate\CSE 210 Programming with Classes\cse210-projects\week06\EternalQuest\goals.txt";
      // create the file in append mode
      using (StreamWriter outputFile = new StreamWriter(filename))
      {
         //write the score in line 1 in the text file
         outputFile.WriteLine(_score.ToString());
         foreach (Goal goal in _goals)
         {
            string stringRep = goal.GetStringRepresentation();
            outputFile.WriteLine(stringRep);
         }
      }
   }
   //Ask user for a file name
   //Read each line of the file and split it up
   //Use the parts to re-create the Goal object
   public void LoadGoals()
   {
      //clean current list of goals to populate it with data from file
      _goals.Clear();

      Console.Write("What is the filename for the goal file? ");
      string filename = Console.ReadLine();
      string[] lines = System.IO.File.ReadAllLines("goals.txt");

      //convert the accumulated score from line #1
      _score = int.Parse(lines[0]);

      //following lines needs to be split
      for (int i = 1; i < lines.Count(); i++)
      {
         string[] parts = lines[i].Split("|");

         if (parts[0] == "SimpleGoal")
         // Fields are [0] name, [1] description, [2] points, [3] complete?
         {
            SimpleGoal simpleGoal = new SimpleGoal(parts[0], parts[1], parts[2]);
            simpleGoal.SetIsComplete(parts[3]);
            _goals.Add(simpleGoal);
         }
         else if (parts[0] == "EternalGoal")
         // Fields are [0] name, [1] description, [2] points
         {
            EternalGoal eternalGoal = new EternalGoal(parts[0], parts[1], parts[2]);
            _goals.Add(eternalGoal);
         }
         else if (parts[0] == "ChecklistGoal")
         // Fields are [0] name, [1] description, [2] points, [3] amount completed, [4] target, [5] bonus
         {
            ChecklistGoal checklistGoal = new ChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[4]), int.Parse(parts[4]));
            checklistGoal.SetAmountCompleted(int.Parse(parts[3]));
            _goals.Add(checklistGoal);
         }
      }
   }
}