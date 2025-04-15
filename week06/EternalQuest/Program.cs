using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        //List<Goal> goals = new List<Goal>();
        // SimpleGoal simpleGoal = new SimpleGoal();
        // goals.Add(simpleGoal);

        // Goal goal = goals[0];

        //Create a GoalManager object
        //Calll the start method on that objent

        GoalManager goalObject = new GoalManager();                
        goalObject.Start();            
    }
}