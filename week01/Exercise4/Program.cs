using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        string response;
        int sum = 0;
        float average = 0;
        int largerNumber = 0;       
        List<int> numbers = new List<int>();        
        Console.WriteLine("Enter a list of numbers. Type 0 when finished");
        do
        {       
           Console.Write("Enter number: ");
           response = Console.ReadLine();
           int convertedResponse = int.Parse(response);
           sum = sum + convertedResponse;
           if (convertedResponse != 0)
           {
            numbers.Add(convertedResponse);            
           } 
           if (  convertedResponse > largerNumber  )
           {
            largerNumber = convertedResponse;
           }          
        }  while (response != "0"); 
        Console.WriteLine($"This is numbers : {numbers}");
        Console.WriteLine($"The sum is : {sum}");
        average = ((float)sum)/(numbers.Count);
        Console.WriteLine($"The average is : {average}");
        Console.WriteLine($"The larger number is : {largerNumber}");
    }
}