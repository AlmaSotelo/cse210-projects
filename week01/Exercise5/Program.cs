using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayMessage();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int sqr = SquareNumber(favNumber);
        DisplayResult(name,sqr);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);
        return userNumber;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }
}