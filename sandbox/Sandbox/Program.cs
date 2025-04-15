using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello World! This is the Sandbox Project.");
    
    
      Console.Write("Waht is the filename for the goal file? ");
      string filename = Console.ReadLine();

      // create the file in append mode
      using (StreamWriter outputFile = new StreamWriter(filename))

      //write the score in line 1 in the text file
      outputFile.WriteLine("linea uno");
    }
     
}

    
