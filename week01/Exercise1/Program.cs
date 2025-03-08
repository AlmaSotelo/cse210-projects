using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What us your first name? ");
        string name = Console.ReadLine();
        Console.Write("What us your first lastname? ");
        string lastname = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastname}, {name} {lastname}.");
        
    }
}