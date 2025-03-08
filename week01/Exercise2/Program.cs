using System;
using System.Reflection;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Please enter your grade percentage, not need to enter % sign: ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        string letter;
        letter = null;
        string sign;
        sign = null;
        int modulus = number % 10;

        if (number >= 90)
        {
          letter = "A";          
        }
        else if ((number < 90) && (number >= 80))
        {
           letter = "B"; 
        }
        else if ((number < 80) && (number >= 70))
        {
           letter = "C";   
        }
        else if ((number < 70) && (number >= 60))
        {
           letter = "D";   
        }
        else 
        {
           letter = "F";   
        }

        if ((modulus < 3) && (letter != "F")){
           sign = "-";
        }   
        else if ((modulus >= 7 ) && ( number < 90) && (letter != "F"))
        {
          sign = "+";  
        } 
        else{
          sign = " ";  
        }  
                 
        Console.WriteLine($"Your grade is {letter}{sign}");
        if (number >= 70)
        {
           Console.WriteLine("Congratulations. You passed the course! ");
        }
        else
        {
            Console.WriteLine("You did not pass the course. Keep pressing forward. See you next semester! ");  
        }

    }
}