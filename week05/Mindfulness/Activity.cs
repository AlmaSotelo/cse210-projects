using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

public class Activity
{
   protected string _name;
   protected string _description;
   protected int _duration;
   //Exceeds core requirements.Add list of runs that store all _duration
   protected List<int> _runs = new List<int>();

   //create a constructor to initialize the variables
   public Activity()
   {
      _name = "Breathing Activity";
      _description = "";
      _duration = 0;
   }

   public void DisplayStartingMessage()
   {
      Console.Clear();
      Console.WriteLine($"Welcome to the {_name}\n");
      Console.WriteLine($"{_description}\n");
      Console.Write("\nHow long, in seconds, would you like for your session?");
      //try&catch for Exceeding core requirements
      try
      {
         _duration = int.Parse(Console.ReadLine());
         Console.WriteLine(_duration);
         Console.Clear();
         Console.WriteLine("Get ready...");
      }
      catch
      {
         Console.WriteLine("Invalid entry");
         Console.WriteLine("Let's do it for 30 seconds");
         _duration = 30;
      }

      //call the method to show the spiner
      ShowSpinner(3);
   }

   public void DisplayEndingMessage()
   {
      Console.WriteLine("\nWell done!!\n");
      ShowSpinner(2);
      Console.WriteLine($"You have completed another {_duration} seconds");
      ShowSpinner(3);
      Console.Clear();
   }
   //Exceeds core requirements. 
   public void DisplayRoundsMessage()
   {
      Console.WriteLine($"{_runs.Count()} runs of {_name} with a total of {GetDurationsSum()} seconds");
   }

   public void ShowSpinner(int seconds)
   {
      Stopwatch timer = new Stopwatch();
      timer.Start();
      while (timer.Elapsed.TotalSeconds < seconds)
      {
         Console.Write("|");
         Thread.Sleep(300);
         Console.Write("\b \b");
         Console.Write("/");
         Thread.Sleep(300);
         Console.Write("\b \b");
         Console.Write("-");
         Thread.Sleep(300);
         Console.Write("\b \b");
         Console.Write("\\");
         Thread.Sleep(300);
         Console.Write("\b \b");
      }
      timer.Stop();
      //disapear the spinner
      Console.Write("\b \b");
   }

   public void ShowCountDown(int seconds)
   {
      for (int i = seconds; i > 0; i--)
      {
         Console.Write(i);
         Thread.Sleep(1000);
         Console.Write("\b \b");
      }
   }

   //Exceeds core requirements. To add _duration in list
   public List<int> GetListWithAddedDuration()
   {
      _runs.Add(_duration);
      return _runs;
   }
   //Exceeds core requirements. To sum all _duration in list
   public int GetDurationsSum()
   {
      return _runs.Sum();
   }
}