using System;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string answer = "";
        do
        {        
            int magic;
            int guess;
                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(1, 101);
            int i = 0;             
            do
            {            
                Console.Write("What is your guess between 1 and 100? ");
                string userGuess = Console.ReadLine();
                int guessNumber = int.Parse(userGuess);
                magic = magicNumber;
                guess = guessNumber;
                i++;           
                if (magicNumber > guessNumber)
                {
                    Console.WriteLine("Higher");  
                }
                else if (magicNumber < guessNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }   while (magic != guess) ;
            Console.WriteLine($"You guessed {i} times");
            Console.Write("Do you want to play again (yes/no) ? ");
            answer = Console.ReadLine();
            }while (answer == "yes");
    }
}