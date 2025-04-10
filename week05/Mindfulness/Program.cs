using System;
using System.ComponentModel;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Console.WriteLine("Hello World! This is the Mindfulness Project.\n");
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        while (userInput != "4")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "4")
            {
                //Exceeds core requirements. Displays total runds, total duration, and the name of the activity
                Console.Clear();
                Console.WriteLine("In total you completed:");
                breathingActivity.DisplayRoundsMessage();
                reflectingActivity.DisplayRoundsMessage();
                listingActivity.DisplayRoundsMessage();
                listingActivity.ShowSpinner(10);
                Console.Clear();
                break;
            }
            //Exceeds core requirements. Validates userInput    
            if (userInput != "1" && userInput != "2" && userInput != "3")
            {
                Console.Clear();
                Console.WriteLine("Ivalid input");
            }

            if (userInput == "1")
            {
                //call the method to display the starting message to the screen.                
                breathingActivity.DisplayStartingMessage();
                breathingActivity.Run();
                breathingActivity.DisplayEndingMessage();
                breathingActivity.GetListWithAddedDuration();
            }
            if (userInput == "2")
            {
                //call the method to display the starting message to the screen.
                reflectingActivity.DisplayStartingMessage();
                reflectingActivity.Run();
                reflectingActivity.DisplayEndingMessage();
                reflectingActivity.GetListWithAddedDuration();
            }
            if (userInput == "3")
            {
                //call the method to display the starting message to the screen.
                listingActivity.DisplayStartingMessage();
                listingActivity.Run();
                listingActivity.DisplayEndingMessage();
                listingActivity.GetListWithAddedDuration();
            }

        }
    }
}